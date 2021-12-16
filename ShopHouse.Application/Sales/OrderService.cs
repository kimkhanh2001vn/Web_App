using Microsoft.AspNetCore.Identity;
using ShopHouse.Application.Common;
using ShopHouse.Data.EF;
using ShopHouse.Data.Entities;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Sales;
using System;
using System.Collections.Generic;
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
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                ShipName = request.Name,
                ShipEmail = request.Email,
                ShipAddress = request.Address,
                ShipPhoneNumber = request.PhoneNumber
            };
            var id = await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return ApiSuccessResult<bo>();
        }
    }
}
