#pragma checksum "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af840dd17e0e298e67543b3e52ee84b173ccfd16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TuristCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TuristCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TuristCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af840dd17e0e298e67543b3e52ee84b173ccfd16", @"/Areas/Admin/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3ed2ec165d475c4849411fe7e374511c873ef6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Tur Rotaları</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Şehir</th>\r\n        <th>Fiyat</th>\r\n        <th>Kapasite</th>\r\n        <th>Sitede Gör</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
           Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 680, 2);
            WriteAttributeValue("", 629, "/Destination/DestinationDetails/", 629, 32, true);
#nullable restore
#line 25 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 661, item.DestinationID, 661, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Sitede Gör</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 750, "\"", 813, 2);
            WriteAttributeValue("", 757, "/Admin/Destination/DeleteDestination/", 757, 37, true);
#nullable restore
#line 26 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 794, item.DestinationID, 794, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 878, "\"", 941, 2);
            WriteAttributeValue("", 885, "/Admin/Destination/UpdateDestination/", 885, 37, true);
#nullable restore
#line 27 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
WriteAttributeValue("", 922, item.DestinationID, 922, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Destination\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Destination/AddDestination\" class=\"btn btn-outline-primary\">Yeni Tur Rotası</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
