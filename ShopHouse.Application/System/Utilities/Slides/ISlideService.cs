using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.Application.System.Utilities
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}
