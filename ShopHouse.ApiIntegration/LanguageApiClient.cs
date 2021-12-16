using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public class LanguageApiClient :  BaseApiClient ,ILanguageApiClient
    {
        public LanguageApiClient(IHttpClientFactory httpClientFactory, 
            IConfiguration iconfiguration, 
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory,iconfiguration,httpContextAccessor)
        {
        }
        public async Task<ApiResult<List<languageVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<languageVm>>>($"/api/languages");
        }
    }
}
