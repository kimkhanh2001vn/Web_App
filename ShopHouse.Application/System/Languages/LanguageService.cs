using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopHouse.Data.EF;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _configuration;
        private readonly ShopHouseDbContext _context;
        public LanguageService(IConfiguration configuration, ShopHouseDbContext context)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<ApiResult<List<languageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new languageVm()
            {
                ID = x.Id,
                Name = x.Name
            }).ToListAsync();

            return new ApiSuccessResult<List<languageVm>>(languages);
        }
    }
}
