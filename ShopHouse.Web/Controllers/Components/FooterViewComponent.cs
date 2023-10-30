using Microsoft.AspNetCore.Mvc;
using ShopHouse.ViewModels.Common;
using System.Threading.Tasks;

namespace ShopHouse.Web.Controllers.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
