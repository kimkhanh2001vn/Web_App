#pragma checksum "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca3baf8124234901d52e9e3f128e660af26ab97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\_ViewImports.cshtml"
using ShopHouse.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\_ViewImports.cshtml"
using ShopHouse.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca3baf8124234901d52e9e3f128e660af26ab97", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed63f3574d09d0e6b92e4f72e5675f3c1ea339b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopHouse.ViewModels.Common.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
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
            WriteLiteral("\n");
#nullable restore
#line 28 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"pagination\">\n");
#nullable restore
#line 31 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
     if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item\">\n        <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 892, "\"", 931, 1);
#nullable restore
#line 34 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 899, urlTemplate.Replace("{0}", "1"), 899, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">?????u</a>\n    </li>\n    <li class=\"page-item\">\n        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1072, 1);
#nullable restore
#line 37 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1013, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1013, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tr?????c</a>\n    </li>\n");
#nullable restore
#line 39 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
     for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item active\">\n        <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 45 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\n    </li>\n");
#nullable restore
#line 47 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1438, "\"", 1465, 2);
            WriteAttributeValue("", 1446, "Trang", 1446, 5, true);
#nullable restore
#line 50 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1451, i.ToString(), 1452, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1466, "\"", 1514, 1);
#nullable restore
#line 50 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1473, urlTemplate.Replace("{0}", i.ToString()), 1473, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 51 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
     if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"page-item\">\n        <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1658, "\"", 1693, 1);
#nullable restore
#line 56 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1666, Model.PageCount.ToString(), 1666, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1694, "\"", 1760, 1);
#nullable restore
#line 56 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1701, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1701, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\n    </li>\n    <li class=\"page-item\">\n        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1835, "\"", 1897, 1);
#nullable restore
#line 59 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1842, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 1842, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cu???i</a>\n    </li>\n");
#nullable restore
#line 61 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
#nullable restore
#line 63 "D:\Frameword core\ShopHouse\ShopHouse.Admin\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopHouse.ViewModels.Common.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
