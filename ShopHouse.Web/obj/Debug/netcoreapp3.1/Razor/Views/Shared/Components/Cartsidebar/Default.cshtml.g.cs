#pragma checksum "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ce1d6ecbb8a5fd6ec9ffca88e9145b069cee677aadbe60ec4b16c0fe12b69178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Cartsidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Cartsidebar/Default.cshtml")]
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
#nullable restore
#line 1 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
using ShopHouse.Utilities.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ce1d6ecbb8a5fd6ec9ffca88e9145b069cee677aadbe60ec4b16c0fe12b69178", @"/Views/Shared/Components/Cartsidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f5d0335659ca5f9ce2b1b81a0f2a13f8929ecc242f36c9eb780753f57c9a60a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Cartsidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;
    var list_item = ViewBag.ListCatSidebar;

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce1d6ecbb8a5fd6ec9ffca88e9145b069cee677aadbe60ec4b16c0fe12b691784343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script defer>\r\n        var cartController = new CartController();\r\n        cartController.initialize();\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<!--== Start Sidebar Cart Menu ==-->
<aside class=""sidebar-cart-modal"">
    <div class=""sidebar-cart-inner"">
        <div class=""sidebar-cart-content"">
            <a class=""cart-close"" href=""javascript:void(0);""><i class=""lastudioicon-e-remove""></i></a>
            <div class=""sidebar-cart"">
                <h4 class=""sidebar-cart-title"">Shopping Cart</h4>
                <div class=""product-cart"">
");
#nullable restore
#line 22 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
                     foreach (var item in list_item)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"product-cart-item\">\r\n                            <div class=\"product-img\">\r\n                                <a href=\"shop.html\"><img");
            BeginWriteAttribute("src", " src=\"", 1067, "\"", 1144, 1);
#nullable restore
#line 26 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
WriteAttributeValue("", 1073, Configuration[SystemConstants.Appsettings.BaseAddress] + item.Images, 1073, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1145, "\"", 1151, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            </div>\r\n                            <div class=\"product-info\">\r\n                                <h4 class=\"title\"><a href=\"shop.html\">");
#nullable restore
#line 29 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <span class=\"info\">");
#nullable restore
#line 30 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" × ");
#nullable restore
#line 30 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"product-delete\"><a href=\"#/\">×</a></div>\r\n                        </div>\r\n");
#nullable restore
#line 34 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""cart-total"">
                    <h4>Subtotal: <span id=""lb_total"" class=""money""></span></h4>
                </div>
                <div class=""shipping-info"">
                    <div class=""loading-bar"">
                        <div class=""load-percent""></div>
                        <div class=""label-free-shipping"">
                            <div class=""free-shipping svg-icon-style"">
                                <span class=""svg-icon"" id=""svg-icon-shipping"" data-svg-icon=""assets/img/icons/shop1.svg""></span>
                            </div>
                            <p>Spend £101.10 to get Free Shipping</p>
                        </div>
                    </div>
                </div>
                <div class=""cart-checkout-btn"">
                    <a class=""btn-theme""");
            BeginWriteAttribute("href", " href=\"", 2466, "\"", 2493, 3);
            WriteAttributeValue("", 2473, "/", 2473, 1, true);
#nullable restore
#line 51 "D:\Web_App\ShopHouse.Web\Views\Shared\Components\Cartsidebar\Default.cshtml"
WriteAttributeValue("", 2474, culture, 2474, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2482, "/Cart/Index", 2482, 11, true);
            EndWriteAttribute();
            WriteLiteral(">View cart</a>\r\n                    <a class=\"btn-theme\" href=\"shop-checkout.html\">Checkout</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</aside>\r\n<div class=\"sidebar-cart-overlay\"></div>\r\n<!--== End Sidebar Cart Menu ==-->");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591