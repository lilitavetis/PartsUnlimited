#pragma checksum "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276cd3417c7c23398f57b719f1f6258ab608d856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276cd3417c7c23398f57b719f1f6258ab608d856", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12, true);
            WriteLiteral("<li>\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 12, "\"", 55, 1);
#line 2 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CartSummary\Default.cshtml"
WriteAttributeValue("", 19, Url.Action("Index", "ShoppingCart"), 19, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 56, "\"", 84, 1);
#line 2 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CartSummary\Default.cshtml"
WriteAttributeValue("", 64, ViewBag.CartSummary, 64, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(85, 72, true);
            WriteLiteral(" class=\"head-link\" id=\"shopping-cart-link\">\r\n\r\n        <div>Cart</div>\r\n");
            EndContext();
#line 5 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CartSummary\Default.cshtml"
         if (ViewBag.CartCount > 0)
        {

#line default
#line hidden
            BeginContext(205, 52, true);
            WriteLiteral("            <span class=\"hidden-xs\" id=\"cart-count\">");
            EndContext();
            BeginContext(258, 17, false);
#line 7 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CartSummary\Default.cshtml"
                                               Write(ViewBag.CartCount);

#line default
#line hidden
            EndContext();
            BeginContext(275, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 8 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\CartSummary\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(295, 15, true);
            WriteLiteral("    </a>\r\n</li>");
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
