#pragma checksum "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Views\LayoutPartial\_ScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b18a0b7191e349e467feccac43c3f29d60a89e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutPartial__ScriptsPartial), @"mvc.1.0.view", @"/Views/LayoutPartial/_ScriptsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b18a0b7191e349e467feccac43c3f29d60a89e6", @"/Views/LayoutPartial/_ScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43bb3e469f796bed5876bb2913e2d5d72daad6f5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LayoutPartial__ScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <!-- Template JavaScript -->
<script src=""/Traversal-Liberty/assets/js/jquery-3.3.1.min.js""></script>
<script src=""/Traversal-Liberty/assets/js/theme-change.js""></script>

<!--/slider-js-->
<script src=""/Traversal-Liberty/assets/js/jquery.min.js""></script>
<script src=""/Traversal-Liberty/assets/js/modernizr-2.6.2.min.js""></script>
<script src=""/Traversal-Liberty/assets/js/jquery.zoomslider.min.js""></script>
<!--//slider-js-->

<script src=""/Traversal-Liberty/assets/js/owl.carousel.js""></script>

<!-- script for tesimonials carousel slider -->
<script>
    $(document).ready(function () {
        $(""#owl-demo1"").owlCarousel({
            loop: true,
            margin: 20,
            nav: false,
            responsiveClass: true,
            responsive: {
                0: {
                    items: 1,
                    nav: false
                },
                736: {
                    items: 1,
                    nav: false
                },
                1000: {");
            WriteLiteral(@"
                    items: 1,
                    nav: false,
                    loop: true
                }
            }
        })
    })
</script>
<!-- //script for tesimonials carousel slider -->

<!-- stats number counter-->
<script src=""/Traversal-Liberty/assets/js/jquery.waypoints.min.js""></script>
<script src=""/Traversal-Liberty/assets/js/jquery.countup.js""></script>
<script>
    $('.counter').countUp();
</script>
<!-- //stats number counter -->

<!--/MENU-JS-->
<script>
    $(window).on(""scroll"", function () {
        var scroll = $(window).scrollTop();

        if (scroll >= 80) {
            $(""#site-header"").addClass(""nav-fixed"");
        } else {
            $(""#site-header"").removeClass(""nav-fixed"");
        }
    });

    //Main navigation Active Class Add Remove
    $("".navbar-toggler"").on(""click"", function () {
        $(""header"").toggleClass(""active"");
    });
    $(document).on(""ready"", function () {
        if ($(window).width() > 991) {
            ");
            WriteLiteral("$(\"header\").removeClass(\"active\");\r\n        }\r\n        $(window).on(\"resize\", function () {\r\n            if ($(window).width() > 991) {\r\n                $(\"header\").removeClass(\"active\");\r\n            }\r\n        });\r\n    });\r\n</script>\r\n<!--//MENU-JS-->");
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
