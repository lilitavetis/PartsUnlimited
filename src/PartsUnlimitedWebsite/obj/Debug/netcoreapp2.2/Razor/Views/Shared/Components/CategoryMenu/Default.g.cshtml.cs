#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CategoryMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c9d867046576078d2d1f8f50e2668dbf993329f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c9d867046576078d2d1f8f50e2668dbf993329f", @"/Views/Shared/Components/CategoryMenu/Default.cshtml")]
    public class Views_Shared_Components_CategoryMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartsUnlimited.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CategoryMenu\Default.cshtml"
 foreach (var category in Model)
            {

#line default
#line hidden
            BeginContext(101, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(110, 97, false);
#line 4 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CategoryMenu\Default.cshtml"
   Write(Html.ActionLink(category.Name, "Browse", "Store", new { CategoryId = category.CategoryId }, null));

#line default
#line hidden
            EndContext();
            BeginContext(207, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 5 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CategoryMenu\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(225, 4, true);
            WriteLiteral("<li>");
            EndContext();
            BeginContext(230, 41, false);
#line 6 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CategoryMenu\Default.cshtml"
Write(Html.ActionLink("More", "Index", "Store"));

#line default
#line hidden
            EndContext();
            BeginContext(271, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartsUnlimited.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
