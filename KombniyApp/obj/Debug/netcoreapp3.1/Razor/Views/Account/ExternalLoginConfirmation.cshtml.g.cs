#pragma checksum "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec48f4e1dbe0c1a65dc3b7d901e74edd65d2d79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ExternalLoginConfirmation), @"mvc.1.0.view", @"/Views/Account/ExternalLoginConfirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec48f4e1dbe0c1a65dc3b7d901e74edd65d2d79", @"/Views/Account/ExternalLoginConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde0cb099000a1d3912655c1fefd364ef5f3e561", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ExternalLoginConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KombniyApp.Models.ExternalLoginConfirmationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
  
    ViewBag.Title = "Registrarse";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<h3>Asocie su cuenta ");
#nullable restore
#line 6 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
                Write(ViewBag.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
 using (Html.BeginForm("ExternalLoginConfirmation", "Account", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Formulario de asociación</h4>\r\n    <hr />\r\n");
#nullable restore
#line 14 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-info\">\r\n        Se ha autenticado correctamente con <strong>");
#nullable restore
#line 16 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
                                               Write(ViewBag.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>.\r\n        Introduzca un nombre de usuario para este sitio y haga clic en el botón Registrar para finalizar\r\n        el inicio de sesión.\r\n    </p>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Registrarse\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 35 "C:\Users\merve bilgiç\Documents\GitHub\KombniyApp\KombniyApp\Views\Account\ExternalLoginConfirmation.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KombniyApp.Models.ExternalLoginConfirmationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
