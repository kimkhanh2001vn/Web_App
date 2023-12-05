using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopHouse.Utilities.Constants;
using ShopHouse.ViewModels.Common;
using ShopHouse.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Controllers.Components
{
    public class CartsidebarViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }

            ViewBag.ListCatSidebar = currentCart;

            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
