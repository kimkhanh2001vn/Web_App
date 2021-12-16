using ShopHouse.Data.EF;
using ShopHouse.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ShopHouse.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ShopHouseDbContext _context;
        public CategoryService(ShopHouseDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            //1.select join
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                ID = x.c.Id,
                Name = x.ct.Name,
                parentId = x.c.ParentId
            }).ToListAsync();
        }
        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId && c.Id == id
                        select new { c, ct };
            return await query.Select(x => new CategoryVm()
            {
                ID = x.c.Id,
                Name = x.ct.Name,
                parentId = x.c.ParentId
            }).FirstOrDefaultAsync();
        }
    }
}
