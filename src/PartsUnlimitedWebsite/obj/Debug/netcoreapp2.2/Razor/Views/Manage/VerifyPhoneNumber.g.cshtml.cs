#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6dc87adc54a809693c172aac805b1d3c40bd8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_VerifyPhoneNumber), @"mvc.1.0.view", @"/Views/Manage/VerifyPhoneNumber.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/VerifyPhoneNumber.cshtml", typeof(AspNetCore.Views_Manage_VerifyPhoneNumber))]
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
#line 1 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
using PartsUnlimited;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6dc87adc54a809693c172aac805b1d3c40bd8a", @"/Views/Manage/VerifyPhoneNumber.cshtml")]
    public class Views_Manage_VerifyPhoneNumber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.Models.VerifyPhoneNumberViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
  
    ViewBag.Title = "Verify Phone Number";

#line default
#line hidden
            BeginContext(131, 21, true);
            WriteLiteral("\r\n<section>\r\n    <h2>");
            EndContext();
            BeginContext(153, 13, false);
#line 8 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(166, 65, true);
            WriteLiteral(".</h2>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n");
            EndContext();
#line 12 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
             using (Html.BeginForm("VerifyPhoneNumber", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
                

#line default
#line hidden
            BeginContext(399, 23, false);
#line 14 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(441, 46, false);
#line 15 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
           Write(Html.Hidden("phoneNumber", @Model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(489, 111, true);
            WriteLiteral("                <h4>Enter verification code</h4>\r\n                <p class=\"text-danger\">\r\n                    ");
            EndContext();
            BeginContext(601, 14, false);
#line 18 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
               Write(ViewBag.Status);

#line default
#line hidden
            EndContext();
            BeginContext(615, 166, true);
            WriteLiteral("\r\n                    <br />\r\n                    Please change this code to register an SMS service in IdentityConfig to send a text message.\r\n                </p>\r\n");
            EndContext();
            BeginContext(798, 58, false);
#line 22 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
           Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(858, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(921, 69, false);
#line 24 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
               Write(Html.LabelFor(m => m.Code, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(990, 135, true);
            WriteLiteral("\r\n                    <div class=\"col-sm-8 col-md-10\">\r\n                        <div class=\"input-group\">\r\n                            ");
            EndContext();
            BeginContext(1126, 83, false);
#line 27 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
                       Write(Html.TextBoxFor(m => m.Code, new { @class = "form-control", placeholder = "Code" }));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 432, true);
            WriteLiteral(@"
                            <span class=""input-group-addon""><img src=""/images/login_safe_icon.png"" /></span>
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-sm-8 col-md-10"">
                        <input type=""submit"" class=""btn btn-default"" value=""Submit"" />
                    </div>
                </div>
");
            EndContext();
#line 37 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\VerifyPhoneNumber.cshtml"
            }

#line default
#line hidden
            BeginContext(1656, 76, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-6\"></div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.Models.VerifyPhoneNumberViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
