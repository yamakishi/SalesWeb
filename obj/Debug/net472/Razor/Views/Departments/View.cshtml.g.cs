#pragma checksum "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ee0bfb51ffd5f04b6761c7e4e0fc28f19fe718dbb69bcb14733063824d41f3cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_View), @"mvc.1.0.view", @"/Views/Departments/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/View.cshtml", typeof(AspNetCore.Views_Departments_View))]
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
#line 1 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\_ViewImports.cshtml"
using SalesWeb;

#line default
#line hidden
#line 2 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\_ViewImports.cshtml"
using SalesWeb.Models;

#line default
#line hidden
#line 3 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\_ViewImports.cshtml"
using SalesWeb.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ee0bfb51ffd5f04b6761c7e4e0fc28f19fe718dbb69bcb14733063824d41f3cb", @"/Views/Departments/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7756f07f83f02f3a492bed187779335111f8426dcf43971120dda73fafbe39ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWeb.Models.Department>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
  
    ViewData["Title"] = "Departments";

#line default
#line hidden
            BeginContext(97, 35, true);
            WriteLiteral("\r\n<h2>Departments</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(132, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee0bfb51ffd5f04b6761c7e4e0fc28f19fe718dbb69bcb14733063824d41f3cb4304", async() => {
                BeginContext(155, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(169, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(262, 38, false);
#line 16 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(300, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(356, 40, false);
#line 19 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(396, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(514, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(563, 37, false);
#line 28 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(600, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(656, 39, false);
#line 31 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(695, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(751, 65, false);
#line 34 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(816, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(837, 71, false);
#line 35 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(908, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(929, 69, false);
#line 36 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(998, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\IoT Projects\Documents\ProjetosDeEstudo\PrimeiroProjeto\SalesWeb\SalesWeb\Views\Departments\View.cshtml"
}

#line default
#line hidden
            BeginContext(1037, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWeb.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
