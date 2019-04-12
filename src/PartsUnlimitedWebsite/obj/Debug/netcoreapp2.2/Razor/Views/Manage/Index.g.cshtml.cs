#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97bf1d493338cb49139ef28755961b90fb61d747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_Index), @"mvc.1.0.view", @"/Views/Manage/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/Index.cshtml", typeof(AspNetCore.Views_Manage_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97bf1d493338cb49139ef28755961b90fb61d747", @"/Views/Manage/Index.cshtml")]
    public class Views_Manage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.Models.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
  
    ViewBag.Title = "Manage";

#line default
#line hidden
            BeginContext(83, 36, true);
            WriteLiteral("<section id=\"manage-page\">\r\n    <h2>");
            EndContext();
            BeginContext(120, 13, false);
#line 6 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(133, 35, true);
            WriteLiteral("</h2>\r\n    <p class=\"text-success\">");
            EndContext();
            BeginContext(169, 21, false);
#line 7 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                       Write(ViewBag.StatusMessage);

#line default
#line hidden
            EndContext();
            BeginContext(190, 153, true);
            WriteLiteral("</p>\r\n    <div>\r\n        <h4>Change your account settings</h4>\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>Email Address:</dt>\r\n            <dd>");
            EndContext();
            BeginContext(344, 18, false);
#line 12 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(362, 76, true);
            WriteLiteral("</dd>\r\n            <dt>Password:</dt>\r\n            <dd>\r\n                [\r\n");
            EndContext();
#line 16 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                 if (Model.HasPassword)
            {
                    

#line default
#line hidden
            BeginContext(515, 57, false);
#line 18 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
               Write(Html.ActionLink("Change your password", "ChangePassword"));

#line default
#line hidden
            EndContext();
#line 18 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                                                                              
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(655, 40, false);
#line 22 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
               Write(Html.ActionLink("Create", "SetPassword"));

#line default
#line hidden
            EndContext();
#line 22 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                                                             
                }

#line default
#line hidden
            BeginContext(716, 111, true);
            WriteLiteral("                ]\r\n            </dd>\r\n            <dt>External Logins:</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(828, 18, false);
#line 28 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
           Write(Model.Logins.Count);

#line default
#line hidden
            EndContext();
            BeginContext(846, 20, true);
            WriteLiteral(" [\r\n                ");
            EndContext();
            BeginContext(867, 41, false);
#line 29 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
           Write(Html.ActionLink("Manage", "ManageLogins"));

#line default
#line hidden
            EndContext();
            BeginContext(908, 23, true);
            WriteLiteral(" ]\r\n            </dd>\r\n");
            EndContext();
            BeginContext(1392, 72, true);
            WriteLiteral("\r\n            <dt>Phone Number:</dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1466, 27, false);
#line 42 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
            Write(Model.PhoneNumber ?? "None");

#line default
#line hidden
            EndContext();
            BeginContext(1494, 4, true);
            WriteLiteral(" [\r\n");
            EndContext();
#line 43 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                 if (Model.PhoneNumber != null)
            {
                    

#line default
#line hidden
            BeginContext(1583, 43, false);
#line 45 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
               Write(Html.ActionLink("Change", "AddPhoneNumber"));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1650, 16, true);
            WriteLiteral(" &nbsp;|&nbsp;\r\n");
            EndContext();
            BeginContext(1687, 46, false);
#line 47 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
               Write(Html.ActionLink("Remove", "RemovePhoneNumber"));

#line default
#line hidden
            EndContext();
#line 47 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                                                                   
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1816, 40, false);
#line 51 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
               Write(Html.ActionLink("Add", "AddPhoneNumber"));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                                                             
                }

#line default
#line hidden
            BeginContext(1877, 105, true);
            WriteLiteral("                ]\r\n            </dd>\r\n            <dt>Two-Factor Authentication:</dt>\r\n            <dd>\r\n");
            EndContext();
#line 57 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                 if (Model.TwoFactor)
                {
                    using (Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post))
                    {
                        

#line default
#line hidden
            BeginContext(2193, 23, false);
#line 61 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2218, 149, true);
            WriteLiteral("                        <span>Enabled</span>\r\n                        <span>[ <input type=\"submit\" value=\"Disable\" class=\"btn btn-link\" /> ]</span>\r\n");
            EndContext();
#line 64 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                    }
                }
                else
                {
                    using (Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post))
                    {
                        

#line default
#line hidden
            BeginContext(2602, 23, false);
#line 70 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2627, 149, true);
            WriteLiteral("                        <span>Enabled</span>\r\n                        <span>[ <input type=\"submit\" value=\"Disable\" class=\"btn btn-link\" /> ]</span>\r\n");
            EndContext();
#line 73 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2818, 79, true);
            WriteLiteral("            </dd>\r\n            <dt>Browser remembered:</dt>\r\n            <dd>\r\n");
            EndContext();
#line 78 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                 if (Model.BrowserRemembered)
            {
                using (Html.BeginForm("ForgetBrowser", "Manage", FormMethod.Post))
                {
                        

#line default
#line hidden
            BeginContext(3087, 23, false);
#line 82 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3112, 203, true);
            WriteLiteral("                            <span>Browser is curently remembered for two factor:</span>\r\n                            <span>[ <input type=\"submit\" value=\"Forget Browser\" class=\"btn btn-link\" /> ]</span>\r\n");
            EndContext();
#line 85 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                    }
                }
                else
                {
                    using (Html.BeginForm("RememberBrowser", "Manage", FormMethod.Post))
                    {
                        

#line default
#line hidden
            BeginContext(3536, 23, false);
#line 91 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3561, 209, true);
            WriteLiteral("                            <span>Browser is curently not remembered for two factor:</span>\r\n                            <span>[ <input type=\"submit\" value=\"Remember Browser\" class=\"btn btn-link\" /> ]</span>\r\n");
            EndContext();
#line 94 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Manage\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3812, 58, true);
            WriteLiteral("            </dd>\r\n        </dl>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
