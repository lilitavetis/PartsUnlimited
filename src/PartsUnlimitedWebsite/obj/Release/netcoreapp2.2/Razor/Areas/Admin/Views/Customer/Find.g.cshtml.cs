#pragma checksum "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Customer\Find.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9189e0bbe789b5d281aafe13bf2d99400ebc146d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_Find), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/Find.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Customer/Find.cshtml", typeof(AspNetCore.Areas_Admin_Views_Customer_Find))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9189e0bbe789b5d281aafe13bf2d99400ebc146d", @"/Areas/Admin/Views/Customer/Find.cshtml")]
    public class Areas_Admin_Views_Customer_Find : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Customer\Find.cshtml"
  
    ViewBag.Title = "Find Customers";

#line default
#line hidden
            BeginContext(46, 133, true);
            WriteLiteral("\r\n<h2>Search for customers:</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row clearfix\">\r\n        <div class=\"col-md-12 column\">\r\n");
            EndContext();
#line 10 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Customer\Find.cshtml"
             using (Html.BeginForm("Find", "Customer", FormMethod.Get))
            {

#line default
#line hidden
            BeginContext(267, 788, true);
            WriteLiteral(@"                <div class=""form-group"">
                    <label for=""username"">Username</label>
                    <input class=""form-control"" id=""username"" name=""username"" type=""text"" />
                </div>
                    <div class=""form-group"">
                        <label for=""email"">Email address</label>
                        <input class=""form-control"" id=""email"" name=""email"" type=""email"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""phoneNumber"">Phone Number:</label>
                        <input class=""form-control"" id=""phoneNumber"" name=""phoneNumber"" type=""number"" />
                    </div>
                    <button class=""btn btn-default"" type=""submit"">Search</button>
");
            EndContext();
#line 25 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Customer\Find.cshtml"
            }

#line default
#line hidden
            BeginContext(1070, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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