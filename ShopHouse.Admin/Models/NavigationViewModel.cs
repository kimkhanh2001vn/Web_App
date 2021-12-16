using ShopHouse.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Admin.Models
{
    public class NavigationViewModel
    {
        public List<languageVm> languages { get; set; }
        public string CurrentLanguegaId { get; set; }
        public string ReturnUrl { get; set; }
    }
}
