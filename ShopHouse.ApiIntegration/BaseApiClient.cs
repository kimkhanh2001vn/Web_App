using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ShopHouse.Utilities.Constants;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public class BaseApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _iconfiguration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected BaseApiClient(IHttpClientFactory httpClientFactory, IConfiguration iconfiguration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _iconfiguration = iconfiguration;
            _httpContextAccessor = httpContextAccessor;
        }
        protected async Task<TResponse> GetAsync<TResponse>(string Url)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_iconfiguration[SystemConstants.Appsettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.GetAsync(Url);

            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TResponse myDeserializeObjList = (TResponse)JsonConvert.DeserializeObject(body, typeof(TResponse));
                return myDeserializeObjList;
            }
            return JsonConvert.DeserializeObject<TResponse>(body);
        }
        protected async Task<List<T>> GetListAsync<T>(string Url, bool requiredLogin = false)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_iconfiguration[SystemConstants.Appsettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.GetAsync(Url);

            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var data = (List<T>)JsonConvert.DeserializeObject(body, typeof(List<T>));
                return data;
            }
            throw new Exception(body);
        }
    }
}
