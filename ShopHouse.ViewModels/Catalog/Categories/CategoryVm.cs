﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.Catalog.Categories
{
    public class CategoryVm
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? parentId { get; set; }
    }
}
