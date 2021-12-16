using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopHouse.Data.Entities;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles
                .Select(x=> new RoleVm() 
            {
                ID = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToListAsync();

            return roles;
        }
    }
}
