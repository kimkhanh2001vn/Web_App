using ShopHouse.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Models
{
    public class CheckOutViewModel
    {
        public List<CartItemViewModel> cartItems { get; set; }
        public CheckOutRequest checkOut { get; set; } 
    }
}
