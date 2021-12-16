using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Models
{
    public class CartItemViewModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
    }
}
