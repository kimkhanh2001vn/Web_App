using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopHouse.Application.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        public readonly ILanguageService _languageService;
        public LanguagesController(ILanguageService languageServices)
        {
            _languageService = languageServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await _languageService.GetAll();
            return Ok(user);
        }
    }
}
