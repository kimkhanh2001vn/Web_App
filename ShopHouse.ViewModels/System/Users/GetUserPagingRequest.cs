using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequsetBase
    {
        public string Keyword { get; set; }
    }
}
