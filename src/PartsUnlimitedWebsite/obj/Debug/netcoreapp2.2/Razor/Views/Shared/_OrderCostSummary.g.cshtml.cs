#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_OrderCostSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aef9dd30554f0cda1afaa1175e74bd76e239e402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderCostSummary), @"mvc.1.0.view", @"/Views/Shared/_OrderCostSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OrderCostSummary.cshtml", typeof(AspNetCore.Views_Shared__OrderCostSummary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef9dd30554f0cda1afaa1175e74bd76e239e402", @"/Views/Shared/_OrderCostSummary.cshtml")]
    public class Views_Shared__OrderCostSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.ViewModels.OrderCostSummary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 293, true);
            WriteLiteral(@"

<div class=""cost-summary"">
    <div class=""row"">
        <div class=""col-xs-12 col-sm-6 col-sm-offset-6 col-md-4 col-md-offset-8"">
            <div class=""row"">
                <div class=""col-xs-6"">Sub Total</div>
                <div class=""col-xs-6 cost-value"" id=""cart-sub-total"">");
            EndContext();
            BeginContext(345, 18, false);
#line 9 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_OrderCostSummary.cshtml"
                                                                Write(Model.CartSubTotal);

#line default
#line hidden
            EndContext();
            BeginContext(363, 181, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-xs-6\">Shipping</div>\r\n                <div class=\"col-xs-6 cost-value\" id=\"cart-shipping\">");
            EndContext();
            BeginContext(545, 18, false);
#line 13 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_OrderCostSummary.cshtml"
                                                               Write(Model.CartShipping);

#line default
#line hidden
            EndContext();
            BeginContext(563, 171, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-xs-6\">Tax</div>\r\n                <div class=\"col-xs-6 cost-value\" id=\"cart-tax\">");
            EndContext();
            BeginContext(735, 13, false);
#line 17 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_OrderCostSummary.cshtml"
                                                          Write(Model.CartTax);

#line default
#line hidden
            EndContext();
            BeginContext(748, 252, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <hr />\r\n            <div class=\"total\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-6 cost-header\">Total</div>\r\n                    <div class=\"col-xs-6 cost-value\" id=\"cart-total\">");
            EndContext();
            BeginContext(1001, 15, false);
#line 23 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_OrderCostSummary.cshtml"
                                                                Write(Model.CartTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 88, true);
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.ViewModels.OrderCostSummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
