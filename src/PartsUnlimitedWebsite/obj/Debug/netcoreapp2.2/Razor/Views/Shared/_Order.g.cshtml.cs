#pragma checksum "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a48d6c000ccab630db38299164113c21c17d0d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Order), @"mvc.1.0.view", @"/Views/Shared/_Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Order.cshtml", typeof(AspNetCore.Views_Shared__Order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48d6c000ccab630db38299164113c21c17d0d48", @"/Views/Shared/_Order.cshtml")]
    public class Views_Shared__Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.ViewModels.OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 36, true);
            WriteLiteral("\r\n<section id=\"order-detail-page\">\r\n");
            EndContext();
#line 4 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(124, 19, true);
            WriteLiteral("        <h2>Order #");
            EndContext();
            BeginContext(144, 19, false);
#line 6 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
              Write(Model.Order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(163, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(172, 535, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">
                <h4>Order Details</h4>

                <div class=""order-header"">
                    <div class=""row"">
                        <div class=""hidden-xs col-sm-8 no-gutter-sm-left""><strong>Product</strong></div>
                        <div class=""hidden-xs col-sm-2""><strong>Quantity</strong></div>
                        <div class=""hidden-xs col-sm-2 text-right""><strong>Price</strong></div>
                    </div>
                </div>

");
            EndContext();
#line 20 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                 foreach (var orderDetail in Model.Order.OrderDetails)
                {

#line default
#line hidden
            BeginContext(798, 179, true);
            WriteLiteral("                    <div class=\"order-detail\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-xs-2 col-sm-2 col-sm-push-8 text-center-xs\">");
            EndContext();
            BeginContext(978, 20, false);
#line 24 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                                                                                   Write(orderDetail.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(998, 81, true);
            WriteLiteral("</div>\r\n                            <div class=\"col-xs-6 col-sm-8 col-sm-pull-2\">");
            EndContext();
            BeginContext(1080, 25, false);
#line 25 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                                                                    Write(orderDetail.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 78, true);
            WriteLiteral("</div>\r\n                            <div class=\"col-xs-4 col-sm-2 text-right\">");
            EndContext();
            BeginContext(1184, 35, false);
#line 26 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                                                                 Write(orderDetail.UnitPrice.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 68, true);
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 29 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                }

#line default
#line hidden
            BeginContext(1306, 397, true);
            WriteLiteral(@"
                <partial name=""_OrderCostSummary"", for=""OrderCostSummary"" />
            </div>

            <div class=""col-md-12"">
                <h4>Purchase Details</h4>
                <div class=""panel panel-default"">
                    <div class=""panel-body"">
                        <dl class=""dl-horizontal"">
                            <dt>
                                ");
            EndContext();
            BeginContext(1704, 50, false);
#line 40 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(1858, 46, false);
#line 43 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(2008, 51, false);
#line 46 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(2163, 47, false);
#line 49 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(2314, 46, false);
#line 52 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2360, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(2464, 42, false);
#line 55 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(2610, 49, false);
#line 58 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(2763, 45, false);
#line 61 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2808, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(2912, 46, false);
#line 64 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.City));

#line default
#line hidden
            EndContext();
            BeginContext(2958, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(3062, 42, false);
#line 67 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.City));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(3208, 49, false);
#line 70 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.Country));

#line default
#line hidden
            EndContext();
            BeginContext(3257, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(3361, 45, false);
#line 73 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.Country));

#line default
#line hidden
            EndContext();
            BeginContext(3406, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(3510, 47, false);
#line 76 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayNameFor(model => model.Order.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(3661, 43, false);
#line 79 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
                           Write(Html.DisplayFor(model => model.Order.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3704, 156, true);
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 86 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3884, 103, true);
            WriteLiteral("        <br />\r\n        <div class=\"alert alert-danger\">\r\n            No order found.\r\n        </div>\r\n");
            EndContext();
#line 93 "C:\Users\Lilit-PC\source\repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Shared\_Order.cshtml"
    }

#line default
#line hidden
            BeginContext(3994, 10, true);
            WriteLiteral("</section>");
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
