#pragma checksum "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3314ca4b55f16b328fe267d1b6604dc21f8f36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarLeft_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarLeft/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\_ViewImports.cshtml"
using ShopHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\_ViewImports.cshtml"
using ShopHouse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3314ca4b55f16b328fe267d1b6604dc21f8f36", @"/Views/Shared/Components/SideBarLeft/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f8bcb7583c54ac5c6a7fb1a9013d4d78ce1042", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBarLeft_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShopHouse.ViewModels.Catalog.Categories.CategoryVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
   var culture = CultureInfo.CurrentCulture.Name; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"col1\">\n    <div class=\"filters\">\n        <ul class=\"button-group tab-flr-btn\">\n");
#nullable restore
#line 17 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-filter=\".burgers\" class=\"btn-flr\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 839, 6);
            WriteAttributeValue("", 800, "/", 800, 1, true);
#nullable restore
#line 20 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
WriteAttributeValue("", 801, culture, 801, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 809, "/", 809, 1, true);
#nullable restore
#line 20 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
WriteAttributeValue("", 810, _loc["categoryUrl"], 810, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 830, "/", 830, 1, true);
#nullable restore
#line 20 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
WriteAttributeValue("", 831, item.ID, 831, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"cat-block\">\n                            <div class=\"block-stl1 bg-2\">\n                                <span class=\"flaticon-taco\"></span>\n                                <h4>");
#nullable restore
#line 24 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                            </div>\n                        </div>\n                    </a>\n                </li>\n");
#nullable restore
#line 29 "D:\Frameword core\ShopHouse\ShopHouse.Web\Views\Shared\Components\SideBarLeft\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n\n");
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShopHouse.ViewModels.Catalog.Categories.CategoryVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
