#pragma checksum "D:\Học kỳ 1 - Năm 4\PTUD HTTT HD\Đồ án cuối kỳ\WebDiChoThue\WebDiChoThue\Views\Shared\_FooterPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7ef5c1880cc4660a1d4fda9a6e6b5a27fe534e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartialView), @"mvc.1.0.view", @"/Views/Shared/_FooterPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7ef5c1880cc4660a1d4fda9a6e6b5a27fe534e1", @"/Views/Shared/_FooterPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7363ce44c7a2c206c5055805023099e971fa7663", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/r4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""footer-area"">
    <div class=""footer-top section-space-y-axis-100 text-black"" data-bg-color=""#e5ddcc"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6"">
                    <div class=""widget-item"">
                        <div class=""footer-logo pb-4"">
                            <a href=""/"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7ef5c1880cc4660a1d4fda9a6e6b5a27fe534e14340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <p class=""short-desc mb-5"">Mang lại dịch vụ hoàn hảo đến với khách hàng.</p>
                        
                        <p class=""short-desc mb-5"">Dịch vụ chất lượng tốt nhất. </p>
                        <div class=""widget-contact-info pb-6"">
                            <ul>
                                <li>
                                    <i class=""pe-7s-map-marker""></i>
                                    PTUD HTTT Hiện đại - Nhóm R4 - Đại học KHTN
                                </li>
                                <li>
                                    <i class=""pe-7s-phone""></i>
                                    0824 777 999
                                </li>
                                <li>
                                    <i class=""pe-7s-mail""></i>
                                    <a href=""mailto://info@example.com"">sonvo24052k@gmail.com</a>
                       ");
            WriteLiteral(@"         </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2 offset-lg-1 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">Thông tin chung</h3>
                        <ul class=""widget-list-item"">
                            <li>
                                <a href=""javascript:void(0)"">
                                    Hỏi Và Đáp
                                </a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Tuyển Dụng</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Liên Hệ</a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-2 offset-lg");
            WriteLiteral(@"-1 col-md-6 pt-10 pt-lg-0"">
                    <div class=""widget-item"">
                        <h3 class=""widget-title mb-5"">Chính sách</h3>
                        <ul class=""widget-list-item"">
                            <li>
                                <a href=""javascript:void(0)"">
                                    Điều Khoản Dịch Vụ
                                </a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Chính Sách Bảo Mật</a>
                            </li>
                            <li>
                                <a href=""javascript:void(0)"">Chính Sách Dịch Vụ</a>
                            </li>
               
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""footer-bottom py-3"" data-bg-color=""#bac34e"">
        <div class=""container"">
            <div class=""row"">
            ");
            WriteLiteral(@"    <div class=""col-lg-12"">
                    <div class=""copyright"">
                        <span class=""copyright-text text-white"">© 2022 Đi chợ thuê - R4 <i class=""fa fa-heart text-danger""></i> by  <a href=""https://hasthemes.com/"" target=""_blank"">Group 4 - KHTN</a> </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
