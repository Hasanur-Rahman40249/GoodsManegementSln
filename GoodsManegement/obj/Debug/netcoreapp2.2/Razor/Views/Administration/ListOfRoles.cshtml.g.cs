#pragma checksum "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e48e572c97070d2286a30f77f1f9bc487ae5e9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListOfRoles), @"mvc.1.0.view", @"/Views/Administration/ListOfRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListOfRoles.cshtml", typeof(AspNetCore.Views_Administration_ListOfRoles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e48e572c97070d2286a30f77f1f9bc487ae5e9c", @"/Views/Administration/ListOfRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb99b04dce665bfd473bada9b5c55cffcce3f6d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListOfRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
   ViewBag.Title = "List of Roles";

#line default
#line hidden
            BeginContext(70, 19, true);
            WriteLiteral("<h3>All Roles</h3>\n");
            EndContext();
#line 4 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(109, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(113, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e48e572c97070d2286a30f77f1f9bc487ae5e9c7392", async() => {
                BeginContext(222, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(237, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
    foreach (var role in Model)
    {

#line default
#line hidden
            BeginContext(276, 95, true);
            WriteLiteral("        <div class=\"card mb-3\">\n            <div class=\"card-header\">\n                Role Id: ");
            EndContext();
            BeginContext(372, 7, false);
#line 12 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
                    Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(379, 95, true);
            WriteLiteral("\n            </div>\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(475, 9, false);
#line 15 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
                                  Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(484, 79, true);
            WriteLiteral("</h5>\n            </div>\n            <div class=\"card-footer\">\n                ");
            EndContext();
            BeginContext(563, 995, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e48e572c97070d2286a30f77f1f9bc487ae5e9c10527", async() => {
                BeginContext(685, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(706, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e48e572c97070d2286a30f77f1f9bc487ae5e9c10929", async() => {
                    BeginContext(834, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
                         WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(842, 26, true);
                WriteLiteral("\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 868, "\"", 899, 2);
                WriteAttributeValue("", 873, "confirmDeleteSpan_", 873, 18, true);
#line 22 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
WriteAttributeValue("", 891, role.Id, 891, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(900, 274, true);
                WriteLiteral(@" style=""display:none"">
                        <span>
                            Are you sure you want to delete this role?
                            <button type=""submit"" class=""btn btn-danger"">Yes</button>
                            <a href=""#"" class=""btn btn-primary""");
                EndContext();
                BeginWriteAttribute("onclick", "\n                               onclick=\"", 1174, "\"", 1247, 4);
                WriteAttributeValue("", 1215, "confirmDelete(\'", 1215, 15, true);
#line 27 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
WriteAttributeValue("", 1230, role.Id, 1230, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1238, "\',", 1238, 2, true);
                WriteAttributeValue(" ", 1240, "false)", 1241, 7, true);
                EndWriteAttribute();
                BeginContext(1248, 93, true);
                WriteLiteral(">No</a>\n                        </span>\n                    </span>\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1341, "\"", 1365, 2);
                WriteAttributeValue("", 1346, "deleteSpan_", 1346, 11, true);
#line 30 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
WriteAttributeValue("", 1357, role.Id, 1357, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1366, 60, true);
                WriteLiteral(">\n                        <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\n                           onclick=\"", 1426, "\"", 1494, 4);
                WriteAttributeValue("", 1463, "confirmDelete(\'", 1463, 15, true);
#line 32 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
WriteAttributeValue("", 1478, role.Id, 1478, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1486, "\',", 1486, 2, true);
                WriteAttributeValue(" ", 1488, "true)", 1489, 6, true);
                EndWriteAttribute();
                BeginContext(1495, 56, true);
                WriteLiteral(">Delete</a>\n                    </span>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
                                                WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1558, 36, true);
            WriteLiteral("\n\n            </div>\n        </div>\n");
            EndContext();
#line 38 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1609, 187, true);
            WriteLiteral("    <div class=\"card\">\n        <div class=\"card-header\">No Role Created Yet</div>\n        <div class=\"card-body\">\n            <h5> Use the button bellow to create a role</h5>\n            ");
            EndContext();
            BeginContext(1796, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e48e572c97070d2286a30f77f1f9bc487ae5e9c20000", async() => {
                BeginContext(1913, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1928, 27, true);
            WriteLiteral("\n        </div>\n    </div>\n");
            EndContext();
#line 50 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfRoles.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(1974, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1979, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e48e572c97070d2286a30f77f1f9bc487ae5e9c22136", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2023, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
