using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<languageVm>>> GetAll();
    }
}
