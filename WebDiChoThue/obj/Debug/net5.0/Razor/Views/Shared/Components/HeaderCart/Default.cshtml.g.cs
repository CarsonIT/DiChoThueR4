#pragma checksum "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a64f8e90095bcb4dae2002a66059683d5ec36f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
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
#line 1 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\_ViewImports.cshtml"
using WebDiChoThue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\_ViewImports.cshtml"
using WebDiChoThue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a64f8e90095bcb4dae2002a66059683d5ec36f8", @"/Views/Shared/Components/HeaderCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7363ce44c7a2c206c5055805023099e971fa7663", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebDiChoThue.ModelViews.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""harmic-offcanvas-body"">
        <div class=""minicart-content"">
            <div class=""minicart-heading"">
                <h4 class=""mb-0"">Giỏ hàng</h4>
                <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
            </div>
            <ul class=""minicart-list"">
");
#nullable restore
#line 11 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
                 foreach (var item in Model)
                {
                    string url = $"/{item.product.Alias}-{item.product.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"minicart-product\">\r\n                        <a class=\"product-item_remove\" href=\"#\">\r\n                            <i class=\"pe-7s-close\"></i>\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 792, "\"", 803, 1);
#nullable restore
#line 18 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 799, url, 799, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-item_img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a64f8e90095bcb4dae2002a66059683d5ec36f85322", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 887, "~/images/products/", 887, 18, true);
#nullable restore
#line 19 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 905, item.product.Thumb, 905, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
AddHtmlAttributeValue("", 931, item.product.ProductName, 931, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                        <div class=\"product-item_content\">\r\n                            <a class=\"product-item_title\"");
            BeginWriteAttribute("href", " href=\"", 1107, "\"", 1118, 1);
#nullable restore
#line 22 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
WriteAttributeValue("", 1114, url, 1114, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                 Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <span class=\"product-item_quantity\">");
#nullable restore
#line 23 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                           Write(item.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 23 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
                                                                          Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 26 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n        <div class=\"minicart-item_total\">\r\n            <span>Tổng tiền</span>\r\n            <span class=\"ammount\">");
#nullable restore
#line 33 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
                             Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span>
        </div>
        <div class=""group-btn_wrap d-grid gap-2"">
            <a href=""cart.html"" class=""btn btn-secondary btn-primary-hover"">Chi tiết giỏ hàng</a>
            <a href=""checkout.html"" class=""btn btn-secondary btn-primary-hover"">Đặt hàng</a>
        </div>
    </div>
");
#nullable restore
#line 40 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""harmic-offcanvas-body"">
        <div class=""minicart-content"">
            <div class=""minicart-heading"">
                <h4 class=""mb-0"">Giỏ hàng rỗng</h4>
                <a href=""#"" class=""button-close""><i class=""pe-7s-close""></i></a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 51 "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\Components\HeaderCart\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebDiChoThue.ModelViews.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
