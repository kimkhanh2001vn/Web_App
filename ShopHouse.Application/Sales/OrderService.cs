using Microsoft.AspNetCore.Identity;
using ShopHouse.Application.Common;
using ShopHouse.Data.EF;
using ShopHouse.Data.Entities;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.Application.Sales
{
    public class OrderService : IOrderService
    {
        private readonly ShopHouseDbContext _context;

        public OrderService(ShopHouseDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<bool>> Create(CheckOutRequest request)
        {
            return new ApiSuccessResult<bool>();
        }
    }
}
