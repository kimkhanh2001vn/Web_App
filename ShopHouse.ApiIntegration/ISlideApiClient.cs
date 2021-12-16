using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}