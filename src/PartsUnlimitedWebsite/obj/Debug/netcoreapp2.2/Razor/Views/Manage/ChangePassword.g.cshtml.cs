#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c42493a4579ccc9ba8a481e1e2af5362338be9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ChangePassword), @"mvc.1.0.view", @"/Views/Manage/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ChangePassword.cshtml", typeof(AspNetCore.Views_Manage_ChangePassword))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 2 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
using PartsUnlimited;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c42493a4579ccc9ba8a481e1e2af5362338be9", @"/Views/Manage/ChangePassword.cshtml")]
    public class Views_Manage_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.Models.ChangePasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
  
    ViewBag.Title = "Change Password";

#line default
#line hidden
            BeginContext(155, 19, true);
            WriteLiteral("<section>\r\n    <h2>");
            EndContext();
            BeginContext(175, 13, false);
#line 8 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(188, 64, true);
            WriteLiteral("</h2>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n");
            EndContext();
#line 12 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
             using (Html.BeginForm("ChangePassword", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
                

#line default
#line hidden
            BeginContext(417, 23, false);
#line 14 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(442, 42, true);
            WriteLiteral("                <h4>Change Password</h4>\r\n");
            EndContext();
            BeginContext(501, 58, false);
#line 16 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
           Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(561, 175, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    <div class=\"col-md-8 col-md-10\">\r\n                        <div class=\"input-group\">\r\n                            ");
            EndContext();
            BeginContext(737, 99, false);
#line 20 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
                       Write(Html.PasswordFor(m => m.OldPassword, new { @class = "form-control", placeholder = "Old Password" }));

#line default
#line hidden
            EndContext();
            BeginContext(836, 371, true);
            WriteLiteral(@"
                            <span class=""input-group-addon""><img src=""/images/login_safe_icon.png"" /></span>
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-8 col-md-10"">
                        <div class=""input-group"">
                            ");
            EndContext();
            BeginContext(1208, 99, false);
#line 28 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
                       Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control", placeholder = "New Password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 371, true);
            WriteLiteral(@"
                            <span class=""input-group-addon""><img src=""/images/login_safe_icon.png"" /></span>
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-8 col-md-10"">
                        <div class=""input-group"">
                            ");
            EndContext();
            BeginContext(1679, 111, false);
#line 36 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
                       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control", placeholder = "Confirm New Password" }));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 441, true);
            WriteLiteral(@"
                            <span class=""input-group-addon""><img src=""/images/login_safe_icon.png"" /></span>
                        </div>
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-sm-8 col-md-10"">
                        <input type=""submit"" value=""Change password"" class=""btn btn-default"" />
                    </div>
                </div>
");
            EndContext();
#line 46 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\ChangePassword.cshtml"
            }

#line default
#line hidden
            BeginContext(2246, 76, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.Models.ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
