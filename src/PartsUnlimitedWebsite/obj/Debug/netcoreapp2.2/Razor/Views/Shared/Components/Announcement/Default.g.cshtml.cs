#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a267d50b919c1306237c52cf025673a8277bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Announcement_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Announcement/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Announcement/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Announcement_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a267d50b919c1306237c52cf025673a8277bec", @"/Views/Shared/Components/Announcement/Default.cshtml")]
    public class Views_Shared_Components_Announcement_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 44, "\"", 113, 4);
            WriteAttributeValue("", 52, "alert", 52, 5, true);
            WriteAttributeValue(" ", 57, "alert-new-arrival", 58, 18, true);
#line 3 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml"
WriteAttributeValue(" ", 75, @Model == null ? "hidden": "show", 76, 36, false);

#line default
#line hidden
            WriteAttributeValue(" ", 112, "", 113, 1, true);
            EndWriteAttribute();
            BeginContext(114, 169, true);
            WriteLiteral(" id=\"alert-new-arrival\" role=\"alert\">\r\n    <div class=\"container\">\r\n        <div class=\"alert-content\">\r\n            <span class=\"glyphicon glyphicon-bullhorn\"></span>\r\n");
            EndContext();
#line 7 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml"
             if (Model == null)
            {

#line default
#line hidden
            BeginContext(331, 51, true);
            WriteLiteral("                <a id=\"new-arrival\" href=\"#\"></a>\r\n");
            EndContext();
#line 10 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(430, 35, true);
            WriteLiteral("                <a id=\"new-arrival\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 465, "\"", 533, 1);
#line 13 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml"
WriteAttributeValue("", 472, Url.Action("Details", "Store", new { id = Model.ProductId }), 472, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(534, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(536, 48, false);
#line 13 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml"
                                                                                                    Write(string.Format(" New Arrival : {0}", Model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(584, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 14 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Announcement\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(605, 34, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
