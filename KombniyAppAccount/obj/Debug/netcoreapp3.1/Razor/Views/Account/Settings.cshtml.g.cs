#pragma checksum "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\Account\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce3bec79b9d46450f15d0c8c7c3b8aff5765355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Settings), @"mvc.1.0.view", @"/Views/Account/Settings.cshtml")]
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
#line 1 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyAppAccount;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\merve bilgiç\Source\Repos\merveBILGIC\KombniyApp\KombniyAppAccount\Views\_ViewImports.cshtml"
using KombniyApp.Core.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce3bec79b9d46450f15d0c8c7c3b8aff5765355", @"/Views/Account/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20f61c0f0ed5faf37ea9e2b7a12cef7a9278380", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Settings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/ChangePassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card o-hidden border-0 shadow-lg my-5"">
    <div class=""card-body p-0"">
        <!-- Nested Row within Card Body -->
        <div class=""row"">
                <div class=""p-5"">
                    <div class=""text-center"">
                        <h1 class=""h4 text-gray-900 mb-2"">Parolayı Güncelle</h1>
                        <p class=""mb-4"">
                            
                        <p>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce3bec79b9d46450f15d0c8c7c3b8aff57653555155", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""password"" class=""form-control form-control-user""
                                   id=""CurrentPassword"" name=""current"" placeholder=""Şuan ki parolanız"">
                        </div>
                        <div class=""form-group"">
                            <input type=""password"" class=""form-control form-control-user""
                                   id=""InputPassword"" name=""pass"" placeholder=""Yeni Parola"">
                        </div>
                        <div class=""form-group"">
                            <input type=""password"" class=""form-control form-control-user""
                                   id=""RepeatPassword"" placeholder=""Yeni Parola Tekrar"">
                        </div>
                        <button type=""submit"" class=""btn btn-primary btn-user btn-block"">
                            Parolayı Güncelle
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
