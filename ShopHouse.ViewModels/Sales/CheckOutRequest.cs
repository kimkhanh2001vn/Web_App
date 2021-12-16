using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.Sales
{
    public class CheckOutRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<OrderDetailVm> OrderDetailVms { get; set; } = new List<OrderDetailVm>();
    }
}
