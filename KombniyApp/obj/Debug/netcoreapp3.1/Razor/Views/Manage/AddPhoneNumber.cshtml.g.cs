#pragma checksum "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a07566597814c8cbbfde33dfa409fed14177208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_AddPhoneNumber), @"mvc.1.0.view", @"/Views/Manage/AddPhoneNumber.cshtml")]
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
#line 1 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\_ViewImports.cshtml"
using KombniyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\_ViewImports.cshtml"
using KombniyApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a07566597814c8cbbfde33dfa409fed14177208", @"/Views/Manage/AddPhoneNumber.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde0cb099000a1d3912655c1fefd364ef5f3e561", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_AddPhoneNumber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KombniyApp.Models.AddPhoneNumberViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
  
    ViewBag.Title = "Número de teléfono";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
 using (Html.BeginForm("AddPhoneNumber", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Agregar un número de teléfono</h4>\r\n    <hr />\r\n");
#nullable restore
#line 13 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
   Write(Html.LabelFor(m => m.Number, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
       Write(Html.TextBoxFor(m => m.Number, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Enviar\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Manage\AddPhoneNumber.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KombniyApp.Models.AddPhoneNumberViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
