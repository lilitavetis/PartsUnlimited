#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef470050293a712d777fd8ddc0880ef2225d4f75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Orders/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Orders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef470050293a712d777fd8ddc0880ef2225d4f75", @"/Areas/Admin/Views/Orders/Details.cshtml")]
    public class Areas_Admin_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.ViewModels.OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Orders\Details.cshtml"
  
    if (Model == null)
    {
        ViewBag.Title = "Unknown order";
    }
    else
    {
        ViewBag.Title = $"Order history for {Model.Order.OrderId}";
    }

#line default
#line hidden
            BeginContext(238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(241, 40, false);
#line 14 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Areas\Admin\Views\Orders\Details.cshtml"
Write(await Html.PartialAsync("_Order", Model));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.ViewModels.OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
