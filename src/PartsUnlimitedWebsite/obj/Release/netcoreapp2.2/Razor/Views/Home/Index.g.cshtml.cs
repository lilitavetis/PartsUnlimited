#pragma checksum "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe2d329ea3417421c9bffafc8fed5389c2cebed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 3 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
using PartsUnlimited;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2d329ea3417421c9bffafc8fed5389c2cebed6", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartsUnlimited.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(136, 66, true);
                WriteLiteral("\r\n    <script>\r\n        $(\'.carousel\').carousel()\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("prebody", async() => {
                BeginContext(225, 639, true);
                WriteLiteral(@"
<div class=""hero-display"">
    <div id=""jumbotron-carousel"" class=""carousel slide"" data-ride=""carousel"">
        <!-- Indicators -->
        <ol class=""carousel-indicators"">
            <li data-target=""#jumbotron-carousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#jumbotron-carousel"" data-slide-to=""1""></li>
            <li data-target=""#jumbotron-carousel"" data-slide-to=""2""></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class=""carousel-inner"" role=""listbox"">
            <div class=""item active"" style=""background-image: url(/images/hero_image1.jpg)"">
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 864, "\"", 925, 1);
#line 28 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 871, Url.Action("Browse", "Store", new { categoryId = 5 }), 871, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(926, 232, true);
                WriteLiteral(" class=\"carousel-wrapper-link\"></a>\r\n                <p>All oil and filters</p>\r\n                <p>20%</p>\r\n                <p>discount</p>\r\n                <div class=\"carousel-caption hidden-xs hidden-sm\">\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1158, "\"", 1219, 1);
#line 33 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1165, Url.Action("Browse", "Store", new { categoryId = 5 }), 1165, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1220, 170, true);
                WriteLiteral(" class=\"carousel-link\">Shop Now</a>\r\n</div>\r\n            </div>\r\n            <div class=\"item\" style=\"background-image: url(/images/hero_image2.jpg)\">\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1390, "\"", 1451, 1);
#line 37 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1397, Url.Action("Browse", "Store", new { categoryId = 3 }), 1397, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1452, 456, true);
                WriteLiteral(@" class=""carousel-wrapper-link""></a>
                <div class=""container"">
                    <p>New tires</p>
                    <ul>
                        <li>Improved fuel efficiency</li>
                        <li>Superior wet weather braking</li>
                        <li>Added durability</li>
                    </ul>
                </div>
                <div class=""carousel-caption hidden-xs hidden-sm"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1908, "\"", 1969, 1);
#line 47 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1915, Url.Action("Browse", "Store", new { categoryId = 3 }), 1915, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1970, 186, true);
                WriteLiteral(" class=\"carousel-link\">Shop Now</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"item\" style=\"background-image: url(/images/hero_image3.jpg)\">\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2156, "\"", 2192, 1);
#line 51 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2163, Url.Action("Index", "Store"), 2163, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2193, 222, true);
                WriteLiteral(" class=\"carousel-wrapper-link\"></a>\r\n                <p>Old<span> or </span>new</p>\r\n                <p>Find the parts for you</p>\r\n                <div class=\"carousel-caption hidden-xs hidden-sm\">\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2415, "\"", 2476, 1);
#line 55 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2422, Url.Action("Browse", "Store", new { categoryId = 3 }), 2422, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2477, 872, true);
                WriteLiteral(@" class=""carousel-link"">Shop Now</a>
                </div>
            </div>
        </div>

        <!-- Controls -->
        <a class=""left carousel-control"" href=""#jumbotron-carousel"" role=""button"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#jumbotron-carousel"" role=""button"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
<div class=""featured-areas"">
    <div class=""container"">
        <section class=""section-alt"">
            <div class=""row"">
                <div class=""area-tile col-xs-12 col-sm-3 col-md-3"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3349, "\"", 3384, 1);
#line 76 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 3356, Url.Action("Index", "Home"), 3356, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3385, 309, true);
                WriteLiteral(@">
                        <img src=""images/submenu_image1.jpg"" alt=""New Season Parts Image"" class=""hidden-xs"" />
                        <div>New Season Parts</div>
                    </a>
                </div>
                <div class=""area-tile col-xs-12 col-sm-3 col-md-3"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3694, "\"", 3729, 1);
#line 82 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 3701, Url.Action("Index", "Home"), 3701, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3730, 301, true);
                WriteLiteral(@">
                        <img src=""images/submenu_image2.jpg"" alt=""How to Guide Image"" class=""hidden-xs"" />
                        <div>How to Guide</div>
                    </a>
                </div>
                <div class=""area-tile col-xs-12 col-sm-3 col-md-3"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4031, "\"", 4066, 1);
#line 88 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 4038, Url.Action("Index", "Home"), 4038, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4067, 321, true);
                WriteLiteral(@">
                        <img src=""images/submenu_image3.jpg"" alt=""Understand Your Engine Image"" class=""hidden-xs"" />
                        <div>Understand Your Engine</div>
                    </a>
                </div>
                <div class=""area-tile col-xs-12 col-sm-3 col-md-3"">
                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4388, "\"", 4423, 1);
#line 94 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 4395, Url.Action("Index", "Home"), 4395, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4424, 270, true);
                WriteLiteral(@">
                        <img src=""images/submenu_image4.jpg"" alt=""Road Trip Tips Image"" class=""hidden-xs"" />
                        <div>Road Trip Tips</div>
            </a>
                </div>
            </div>
        </section>
    </div>
</div>
    ");
                EndContext();
            }
            );
            BeginContext(4697, 587, true);
            WriteLiteral(@"
<a href=""https://github.com/Microsoft/PartsUnlimited"" target=""_blank"" class=""hidden-xs"">
    <img style=""position: absolute; top: 0; left: 0; border: 0;"" src=""https://camo.githubusercontent.com/c6625ac1f3ee0a12250227cf83ce904423abf351/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f6769746875622f726962626f6e732f666f726b6d655f6c6566745f677261795f3664366436642e706e67"" alt=""Fork me on GitHub"" data-canonical-src=""https://s3.amazonaws.com/github/ribbons/forkme_left_gray_6d6d6d.png"">
</a>
<div id=""home-page"">
    <section class=""section-alt"">
        <h2>Arrivals</h2>
        ");
            EndContext();
            BeginContext(5285, 58, false);
#line 111 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_ProductList", Model.NewProducts));

#line default
#line hidden
            EndContext();
            BeginContext(5343, 91, true);
            WriteLiteral("\r\n    </section>\r\n    <section class=\"section-alt\">\r\n        <h2>Top Selling</h2>\r\n        ");
            EndContext();
            BeginContext(5435, 65, false);
#line 115 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_ProductList", Model.TopSellingProducts));

#line default
#line hidden
            EndContext();
            BeginContext(5500, 89, true);
            WriteLiteral("\r\n    </section>\r\n    <section class=\"section-alt\">\r\n        <h2>Community</h2>\r\n        ");
            EndContext();
            BeginContext(5590, 63, false);
#line 119 "C:\Users\Lilit-PC\Source\Repos\partsunlimited\src\PartsUnlimitedWebsite\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_CommunityList", Model.CommunityPosts));

#line default
#line hidden
            EndContext();
            BeginContext(5653, 26, true);
            WriteLiteral("\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartsUnlimited.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
