#pragma checksum "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "258e9bc55d8b8cab5679e89ba940490eef75efbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
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
#line 2 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258e9bc55d8b8cab5679e89ba940490eef75efbb", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35c9e85769d47bd0cf7187da04d9af312a57049f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/ProductDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h6 class=""display-4"">Admin Products Managament</h6>
        <hr />
        <a href=""/admin/products/create"" class=""btn btn-sm btn-primary"">Create Product</a>
        <table class=""table table-bordered mt-2"">
            <thead>
                <tr>
                    <th width=""30"">ID</th>
                    <th width=""100"">Image</th>
                    <th>Name</th>
                    <th width=""30"">Home</th>
                    <th width=""30"">Approved</th>
                    <th width=""30"">Price</th>
                    <th width=""140"">Actions</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                 if (Model.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                     foreach (var product in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 26 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                           Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "258e9bc55d8b8cab5679e89ba940490eef75efbb7664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 959, "~/img/", 959, 6, true);
#nullable restore
#line 27 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 965, product.ImageUrl, 965, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 28 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n");
#nullable restore
#line 30 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                 if (product.IsHome)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fa-solid fa-circle-check text-success\"></i>\n");
#nullable restore
#line 33 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\n");
#nullable restore
#line 37 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 40 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                 if (product.IsApproved)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fa-solid fa-circle-check text-success\"></i>\n");
#nullable restore
#line 43 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fa-solid fa-circle-xmark text-danger\"></i>\n");
#nullable restore
#line 47 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>");
#nullable restore
#line 49 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2121, "\"", 2162, 2);
            WriteAttributeValue("", 2128, "/admin/products/", 2128, 16, true);
#nullable restore
#line 51 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2144, product.ProductId, 2144, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary mr-1\">Edit</a>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "258e9bc55d8b8cab5679e89ba940490eef75efbb12853", async() => {
                WriteLiteral("\n                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 2383, "\"", 2409, 1);
#nullable restore
#line 53 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2391, product.ProductId, 2391, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 58 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Admin\ProductList.cshtml"
                     
                }
                else
                {
                    //ÜRün olmadığında yapılacak işlem
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
