#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Recommendations\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e8d77d468f5ad3bfb7abcc90d4c1294d941e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Recommendations_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Recommendations/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Recommendations/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Recommendations_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e8d77d468f5ad3bfb7abcc90d4c1294d941e37", @"/Views/Shared/Components/Recommendations/Default.cshtml")]
    public class Views_Shared_Components_Recommendations_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 69, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">$(function () { getRecommendations(\"");
            EndContext();
            BeginContext(108, 22, false);
#line 3 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\Components\Recommendations\Default.cshtml"
                                                              Write(Model.RecommendationId);

#line default
#line hidden
            EndContext();
            BeginContext(130, 59, true);
            WriteLiteral("\"); })</script>\r\n\r\n<div id=\"recommendations-panel\"></div>\r\n");
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
