using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<bool>> CreateOrder(CheckOutRequest request);
    }
}
