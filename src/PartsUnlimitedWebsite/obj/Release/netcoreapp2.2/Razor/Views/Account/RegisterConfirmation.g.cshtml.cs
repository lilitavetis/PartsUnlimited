#pragma checksum "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc5f7e4a3b8115452553c5b53b9b8898c7b4234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterConfirmation), @"mvc.1.0.view", @"/Views/Account/RegisterConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterConfirmation.cshtml", typeof(AspNetCore.Views_Account_RegisterConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc5f7e4a3b8115452553c5b53b9b8898c7b4234", @"/Views/Account/RegisterConfirmation.cshtml")]
    public class Views_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Account\RegisterConfirmation.cshtml"
  
    ViewBag.Title = "Register Confirmation";

#line default
#line hidden
            BeginContext(53, 19, true);
            WriteLiteral("<section>\r\n    <h1>");
            EndContext();
            BeginContext(73, 13, false);
#line 5 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Account\RegisterConfirmation.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(86, 264, true);
            WriteLiteral(@"</h1>
    <div class=""row"">
        <div class=""col-md-6"">
            <div>
                <p>
                    Please check your email to activate your account.
                </p>
                <p>
                    Demo/testing purposes only: ");
            EndContext();
            BeginContext(351, 121, false);
#line 13 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Account\RegisterConfirmation.cshtml"
                                           Write(Html.ActionLink("Click here to confirm your email", "ConfirmEmail", new { code = ViewBag.Code, userId = ViewBag.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(472, 120, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-6\"></div>\r\n    </div>\r\n</section>");
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