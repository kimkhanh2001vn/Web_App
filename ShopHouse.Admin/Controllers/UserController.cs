using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShopHouse.ApiIntegration;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Users;
using System;
using System.Threading.Tasks;

namespace ShopHouse.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        private readonly IRoleApiClient _roleApiClient;

        public UserController(IUserApiClient userApiClient, IConfiguration configuration, IRoleApiClient roleApiClient)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
            _roleApiClient = roleApiClient;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            //var session = HttpContext.Session.GetString("Token");
            var request = new GetUserPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userApiClient.GetUserPagings(request);
            if(TempData["result"] != null)
            {
                ViewBag.successMsg = TempData["result"];
            }
            ViewBag.keyword = keyword;

            return View(data.ResultObj);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            return View(result.ResultObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userApiClient.RegisterUser(request);
            if (result.IsSuccessed)
            {
                TempData["result"] = "Thêm người dùng thành công.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(new UserDeleteRequest()
            {
                ID = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UserDeleteRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userApiClient.Delete(request.ID);
            if (user.IsSuccessed)
            {
                TempData["result"] = "Xóa người dùng thành công.";
                return RedirectToAction("Index", "User");
            }
            ModelState.AddModelError("", user.Message);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var resultObj = await _userApiClient.GetById(id);
            if (resultObj != null)
            {
                var user = resultObj.ResultObj;

                var Updaterequest = new UserUpdateRequest()
                {
                    Dob = user.Dob,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    ID = id
                };
                return View(Updaterequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.UpdateUser(request.ID, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật người dùng thành công.";
                return RedirectToAction("Index", "User");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Login");
        }
        [HttpGet]
        public async Task<IActionResult> RoleAssign(Guid id)
        {
            var roleAssignRequest = await GetRoleAssignRequest(id);
            return View(roleAssignRequest);
        }

        [HttpPost]
        public async Task<IActionResult> RoleAssign(RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.RoleAssign(request.ID, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Gán quyền thành công.";
                return RedirectToAction("Index", "User");
            }
            var roleAssignRequest = await GetRoleAssignRequest(request.ID);
            ModelState.AddModelError("", result.Message);
            return View(roleAssignRequest);
        }
        private async Task<RoleAssignRequest> GetRoleAssignRequest(Guid id)
        {
            var userObj = await _userApiClient.GetById(id);
            var rolesObj = await _roleApiClient.GetAll();
            var roleRequest = new RoleAssignRequest();
            foreach (var item in rolesObj.ResultObj)
            {
                roleRequest.Roles.Add(new SelectItem()
                {
                    ID = item.ID.ToString(),
                    Name = item.Name,
                    Selected = userObj.ResultObj.Roles.Contains(item.Name)
                });
            }
            return roleRequest;
        }
    }
}