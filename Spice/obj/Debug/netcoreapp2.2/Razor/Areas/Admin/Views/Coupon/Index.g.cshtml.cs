#pragma checksum "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d65f812976956fe842eedf44d07c30dd56dea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Coupon_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Coupon/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Coupon/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Coupon_Index))]
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
#line 1 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#line 2 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d65f812976956fe842eedf44d07c30dd56dea2", @"/Areas/Admin/Views/Coupon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1390ba8093fb4c2e21d25b459146d9962f6bcb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Coupon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Coupon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
            BeginContext(214, 248, true);
            WriteLiteral("\r\n    <br /><br />\r\n    <div class=\"border backgroundWhite\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n\r\n                <h2 class=\"text-info\">Coupon List</h2>\r\n\r\n            </div>\r\n\r\n            <div class=\"col-6 text-right\">\r\n");
            EndContext();
            BeginContext(506, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(522, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6d65f812976956fe842eedf44d07c30dd56dea24731", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(561, 71, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <br />\r\n        <div>\r\n");
            EndContext();
            BeginContext(721, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
            BeginContext(775, 60, true);
            WriteLiteral("                <table class=\"table table-striped border\">\r\n");
            EndContext();
            BeginContext(914, 108, true);
            WriteLiteral("                    <tr class=\"table-secondary\">\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1023, 32, false);
#line 34 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1147, 36, false);
#line 37 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1275, 41, false);
#line 40 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.MinimumAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1408, 36, false);
#line 43 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 132, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n\r\n");
            EndContext();
#line 50 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1729, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1802, 31, false);
#line 54 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1913, 35, false);
#line 57 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2028, 40, false);
#line 60 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.MinimumAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2148, 35, false);
#line 63 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                   Write(Html.DisplayFor(m => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2262, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6d65f812976956fe842eedf44d07c30dd56dea210816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 66 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2316, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2391, 26, true);
            WriteLiteral("                </table>\r\n");
            EndContext();
#line 71 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
            }
            

#line default
#line hidden
#line 72 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
                                                                        
            else
            {

#line default
#line hidden
            BeginContext(2539, 42, true);
            WriteLiteral("                <p>No Coupons exists</p>\r\n");
            EndContext();
#line 76 "C:\Users\Olasunkanmi\Documents\DIG\Spice\Spice\Areas\Admin\Views\Coupon\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2596, 34, true);
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Coupon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
