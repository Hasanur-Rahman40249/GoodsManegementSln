#pragma checksum "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "953171b59f90bf959a087c396cb6c6601acca0bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListOfUsers), @"mvc.1.0.view", @"/Views/Administration/ListOfUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListOfUsers.cshtml", typeof(AspNetCore.Views_Administration_ListOfUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"953171b59f90bf959a087c396cb6c6601acca0bc", @"/Views/Administration/ListOfUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb99b04dce665bfd473bada9b5c55cffcce3f6d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListOfUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
   ViewBag.Title = "All Users";

#line default
#line hidden
            BeginContext(70, 19, true);
            WriteLiteral("<h1>All Users</h1>\n");
            EndContext();
#line 5 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(109, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(113, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953171b59f90bf959a087c396cb6c6601acca0bc8101", async() => {
                BeginContext(213, 11, true);
                WriteLiteral("Create User");
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
            BeginContext(228, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
    foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(267, 95, true);
            WriteLiteral("        <div class=\"card mb-3\">\n            <div class=\"card-header\">\n                User Id: ");
            EndContext();
            BeginContext(363, 7, false);
#line 13 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
                    Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(370, 95, true);
            WriteLiteral("\n            </div>\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(466, 13, false);
#line 16 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
                                  Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(479, 79, true);
            WriteLiteral("</h5>\n            </div>\n            <div class=\"card-footer\">\n                ");
            EndContext();
            BeginContext(558, 915, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953171b59f90bf959a087c396cb6c6601acca0bc11241", async() => {
                BeginContext(658, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(679, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953171b59f90bf959a087c396cb6c6601acca0bc11643", async() => {
                    BeginContext(807, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
                         WriteLiteral(user.Id);

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
                BeginContext(815, 26, true);
                WriteLiteral("\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 841, "\"", 872, 2);
                WriteAttributeValue("", 846, "confirmDeleteSpan_", 846, 18, true);
#line 22 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
WriteAttributeValue("", 864, user.Id, 864, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(873, 274, true);
                WriteLiteral(@" style=""display:none"">
                        <span>
                            Are you sure you want to delete this user?
                            <button type=""submit"" class=""btn btn-danger"">Yes</button>
                            <a href=""#"" class=""btn btn-primary""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1147, "\"", 1189, 4);
                WriteAttributeValue("", 1157, "confirmDelete(\'", 1157, 15, true);
#line 26 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
WriteAttributeValue("", 1172, user.Id, 1172, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1180, "\',", 1180, 2, true);
                WriteAttributeValue(" ", 1182, "false)", 1183, 7, true);
                EndWriteAttribute();
                BeginContext(1190, 93, true);
                WriteLiteral(">No</a>\n                        </span>\n                    </span>\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1283, "\"", 1307, 2);
                WriteAttributeValue("", 1288, "deleteSpan_", 1288, 11, true);
#line 29 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
WriteAttributeValue("", 1299, user.Id, 1299, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1308, 60, true);
                WriteLiteral(">\n                        <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1368, "\"", 1409, 4);
                WriteAttributeValue("", 1378, "confirmDelete(\'", 1378, 15, true);
#line 30 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
WriteAttributeValue("", 1393, user.Id, 1393, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1401, "\',", 1401, 2, true);
                WriteAttributeValue(" ", 1403, "true)", 1404, 6, true);
                EndWriteAttribute();
                BeginContext(1410, 56, true);
                WriteLiteral(">Delete</a>\n                    </span>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
                                                WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1473, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
#line 35 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1523, 187, true);
            WriteLiteral("    <div class=\"card\">\n        <div class=\"card-header\">No User Created Yet</div>\n        <div class=\"card-body\">\n            <h5> Use the button bellow to create a user</h5>\n            ");
            EndContext();
            BeginContext(1710, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953171b59f90bf959a087c396cb6c6601acca0bc20652", async() => {
                BeginContext(1822, 11, true);
                WriteLiteral("Create User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
            BeginContext(1837, 27, true);
            WriteLiteral("\n        </div>\n    </div>\n");
            EndContext();
#line 47 "C:\Users\Hasanur Rahman\Downloads\GoodsManagementSystem-main\GoodsManegementSln\GoodsManegement\Views\Administration\ListOfUsers.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(1883, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1888, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953171b59f90bf959a087c396cb6c6601acca0bc22788", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1932, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
