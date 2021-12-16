using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopHouse.Data.EF;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Application.System.Utilities
{
    public class SlideService : ISlideService
    {
        private readonly IConfiguration _configuration;
        private readonly ShopHouseDbContext _context;

        public SlideService(IConfiguration configuration, ShopHouseDbContext context)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder).
                Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Image = x.Image,
                    Url = x.Url
                }).ToListAsync();

            return slides;
        }
    }
}