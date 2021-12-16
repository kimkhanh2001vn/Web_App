using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<languageVm>>> GetAll();
    }
}
