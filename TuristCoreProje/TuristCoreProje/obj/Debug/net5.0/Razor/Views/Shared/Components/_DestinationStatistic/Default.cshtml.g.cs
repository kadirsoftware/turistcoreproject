#pragma checksum "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Views\Shared\Components\_DestinationStatistic\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f56fd055931cb42b0824b3309f199e3207f7693f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DestinationStatistic_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DestinationStatistic/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Views\_ViewImports.cshtml"
using TuristCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Views\_ViewImports.cshtml"
using TuristCoreProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56fd055931cb42b0824b3309f199e3207f7693f", @"/Views/Shared/Components/_DestinationStatistic/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43bb3e469f796bed5876bb2913e2d5d72daad6f5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__DestinationStatistic_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-6 col-lg-4 col-xl-4 order-0 mb-4"">
    <div class=""card h-100"">
        <div class=""card-header d-flex align-items-center justify-content-between pb-0"">
            <div class=""card-title mb-0"">
                <h5 class=""m-0 me-2"">Order Statistics</h5>
                <small class=""text-muted"">42.82k Total Sales</small>
            </div>
            <div class=""dropdown"">
                <button class=""btn p-0""
                        type=""button""
                        id=""orederStatistics""
                        data-bs-toggle=""dropdown""
                        aria-haspopup=""true""
                        aria-expanded=""false"">
                    <i class=""bx bx-dots-vertical-rounded""></i>
                </button>
                <div class=""dropdown-menu dropdown-menu-end"" aria-labelledby=""orederStatistics"">
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Select All</a>
                    <a class=""dropdown-item"" href=""javascript:void(0);"">Refresh</a>
    ");
            WriteLiteral(@"                <a class=""dropdown-item"" href=""javascript:void(0);"">Share</a>
                </div>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""d-flex justify-content-between align-items-center mb-3"">
                <div class=""d-flex flex-column align-items-center gap-1"">
                    <h2 class=""mb-2"">8,258</h2>
                    <span>Total Orders</span>
                </div>
                <div id=""orderStatisticsChart""></div>
            </div>
            <ul class=""p-0 m-0"">
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-primary"">
                            <i class=""bx bx-mobile-alt""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                         ");
            WriteLiteral(@"   <h6 class=""mb-0"">Electronic</h6>
                            <small class=""text-muted"">Mobile, Earbuds, TV</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">82.5k</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Fashion</h6>
                            <small class=""text-muted"">T-shirt, Jeans, Shoes</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold");
            WriteLiteral(@""">23.8k</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-info""><i class=""bx bx-home-alt""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Decor</h6>
                            <small class=""text-muted"">Fine Art, Dining</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">849k</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-se");
            WriteLiteral(@"condary"">
                            <i class=""bx bx-football""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Sports</h6>
                            <small class=""text-muted"">Football, Cricket Kit</small>
                        </div>
                        <div class=""user-progress"">
                            <small class=""fw-semibold"">99</small>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
