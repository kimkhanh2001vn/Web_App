using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.Common
{
    public class PagingRequsetBase 
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
