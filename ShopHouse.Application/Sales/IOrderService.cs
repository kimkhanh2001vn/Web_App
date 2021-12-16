using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.Application.Sales
{
    public interface IOrderService
    {
        Task<ApiResult<bool>> Create(CheckOutRequest request);
    }
}
