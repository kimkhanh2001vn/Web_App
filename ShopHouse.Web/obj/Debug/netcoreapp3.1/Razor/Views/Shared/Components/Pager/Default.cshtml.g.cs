#pragma checksum "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7fba5d997c277522b576236fbc713bb65624902a4bc82d079644e6de905642dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Web_App\ShopHouse.Web\Views\_ViewImports.cshtml"
using ShopHouse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web_App\ShopHouse.Web\Views\_ViewImports.cshtml"
using ShopHouse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Web_App\ShopHouse.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7fba5d997c277522b576236fbc713bb65624902a4bc82d079644e6de905642dd", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f5d0335659ca5f9ce2b1b81a0f2a13f8929ecc242f36c9eb780753f57c9a60a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopHouse.ViewModels.Common.PagedResultBase>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
   var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"pagination\">\r\n");
#nullable restore
#line 29 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
     if (Model.PageIndex != startIndex)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"page-item\">\r\n    <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 897, "\"", 936, 1);
#nullable restore
#line 32 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 904, urlTemplate.Replace("{0}", "1"), 904, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n</li>\r\n                    <li class=\"page-item\">\r\n                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1042, "\"", 1108, 1);
#nullable restore
#line 35 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1049, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1049, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n                    </li>");
#nullable restore
#line 36 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
     for (var i = startIndex; i <= finishIndex; i++)
    {
        if (i == Model.PageIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\">\r\n                <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 42 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n            </li> \r\n");
#nullable restore
#line 44 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1502, "\"", 1529, 2);
            WriteAttributeValue("", 1510, "Trang", 1510, 5, true);
#nullable restore
#line 47 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1515, i.ToString(), 1516, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1530, "\"", 1578, 1);
#nullable restore
#line 47 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1537, urlTemplate.Replace("{0}", i.ToString()), 1537, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>");
#nullable restore
#line 47 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                               }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1742, "\"", 1777, 1);
#nullable restore
#line 52 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1750, Model.PageCount.ToString(), 1750, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1778, "\"", 1844, 1);
#nullable restore
#line 52 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1785, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1785, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n                </li>\r\n                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1958, "\"", 2020, 1);
#nullable restore
#line 55 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1965, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 1965, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n                </li>\r\n");
#nullable restore
#line 57 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
#nullable restore
#line 58 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Pager\Default.cshtml"
     }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopHouse.ViewModels.Common.PagedResultBase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
