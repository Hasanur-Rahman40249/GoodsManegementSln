#pragma checksum "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d7f79b2a0bb7012fbabea10b1e1ef9a5b3d9ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Good_Details), @"mvc.1.0.view", @"/Views/Good/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Good/Details.cshtml", typeof(AspNetCore.Views_Good_Details))]
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
#line 1 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\_ViewImports.cshtml"
using GoodsManegement;

#line default
#line hidden
#line 2 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\_ViewImports.cshtml"
using GoodsManegement.Models;

#line default
#line hidden
#line 3 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\_ViewImports.cshtml"
using GoodsManegement.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d7f79b2a0bb7012fbabea10b1e1ef9a5b3d9ea", @"/Views/Good/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb99b04dce665bfd473bada9b5c55cffcce3f6d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Good_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoodsManegement.Models.Good>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ImageView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(71, 57, true);
            WriteLiteral("<div>\n    <dl>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(129, 43, false);
#line 8 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GoodsId));

#line default
#line hidden
            EndContext();
            BeginContext(172, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(231, 39, false);
#line 11 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayFor(model => model.GoodsId));

#line default
#line hidden
            EndContext();
            BeginContext(270, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(328, 45, false);
#line 14 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GoodsName));

#line default
#line hidden
            EndContext();
            BeginContext(373, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(432, 41, false);
#line 17 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayFor(model => model.GoodsName));

#line default
#line hidden
            EndContext();
            BeginContext(473, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(531, 46, false);
#line 20 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GoodsPrice));

#line default
#line hidden
            EndContext();
            BeginContext(577, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(636, 42, false);
#line 23 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayFor(model => model.GoodsPrice));

#line default
#line hidden
            EndContext();
            BeginContext(678, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(736, 44, false);
#line 26 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UrlImage));

#line default
#line hidden
            EndContext();
            BeginContext(780, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(838, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "37d7f79b2a0bb7012fbabea10b1e1ef9a5b3d9ea8254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 848, "~/imags/", 848, 8, true);
#line 29 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
AddHtmlAttributeValue("", 856, Model.UrlImage, 856, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(914, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(972, 44, false);
#line 32 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1075, 53, false);
#line 35 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Good\Details.cshtml"
       Write(Html.DisplayFor(model => model.Supplier.SupplierName));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 31, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoodsManegement.Models.Good> Html { get; private set; }
    }
}
#pragma warning restore 1591