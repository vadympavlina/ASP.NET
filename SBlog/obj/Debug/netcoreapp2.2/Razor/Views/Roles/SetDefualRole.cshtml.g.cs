#pragma checksum "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20220b2055fd52b1bce22d606e8dac586d2e45d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_SetDefualRole), @"mvc.1.0.view", @"/Views/Roles/SetDefualRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/SetDefualRole.cshtml", typeof(AspNetCore.Views_Roles_SetDefualRole))]
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
#line 1 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\_ViewImports.cshtml"
using MVC_Intro;

#line default
#line hidden
#line 2 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\_ViewImports.cshtml"
using MVC_Intro.Models;

#line default
#line hidden
#line 3 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\_ViewImports.cshtml"
using MVC_Intro.ViewModel;

#line default
#line hidden
#line 1 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20220b2055fd52b1bce22d606e8dac586d2e45d8", @"/Views/Roles/SetDefualRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a59fa1dd4b5f3d41ba1fdc40e7f1dd84a49812", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_SetDefualRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 76, true);
            WriteLiteral("\r\n<div class=\"fancy-border-post\">\r\n    <h2>Изменение ролей для пользователя ");
            EndContext();
            BeginContext(115, 15, false);
#line 4 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
                                    Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(130, 13, true);
            WriteLiteral("</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(143, 745, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20220b2055fd52b1bce22d606e8dac586d2e45d84644", async() => {
                BeginContext(181, 44, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 225, "\"", 246, 1);
#line 7 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
WriteAttributeValue("", 233, Model.UserId, 233, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(247, 39, true);
                WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n");
                EndContext();
#line 9 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
             foreach (IdentityRole role in Model.AllRoles)
            {
                if (role.Name=="Admin")
                {

                }
                if (role.Name=="Manager")
                {

                }
                else
                {


#line default
#line hidden
                BeginContext(568, 51, true);
                WriteLiteral("                <input type=\"checkbox\" name=\"roles\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 619, "\"", 637, 1);
#line 22 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
WriteAttributeValue("", 627, role.Name, 627, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(638, 25, true);
                WriteLiteral("\r\n                       ");
                EndContext();
                BeginContext(665, 64, false);
#line 23 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
                   Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(730, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(734, 9, false);
#line 23 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
                                                                                        Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(743, 9, true);
                WriteLiteral(" <br />\r\n");
                EndContext();
#line 24 "C:\Users\vadim\Desktop\ASP.NET\SBlog\Views\Roles\SetDefualRole.cshtml"
                }
                }

#line default
#line hidden
                BeginContext(790, 91, true);
                WriteLiteral("        </div>\r\n        <button type=\"submit\" class=\"btn btn-info\">Сохранить</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(888, 27, true);
            WriteLiteral("\r\n    <hr />\r\n   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591