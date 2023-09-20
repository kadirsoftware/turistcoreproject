#pragma checksum "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Role\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999e4fc6ee663fffe6e56526e4d950d321ce2815"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_UserList), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/UserList.cshtml")]
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
#line 2 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999e4fc6ee663fffe6e56526e4d950d321ce2815", @"/Areas/Admin/Views/Role/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3ed2ec165d475c4849411fe7e374511c873ef6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Role_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Role\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Kullanıcı Listesi</h1>\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>Kullanıcı Adı</th>\n        <th>Rol Ata</th>\n    </tr>\n");
#nullable restore
#line 14 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Role\UserList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 17 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Role\UserList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 360, "\"", 398, 2);
            WriteAttributeValue("", 367, "/Admin/Role/AssignRole/", 367, 23, true);
#nullable restore
#line 18 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Role\UserList.cshtml"
WriteAttributeValue("", 390, item.Id, 390, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Rol Ata</a></td>\n        </tr>\n");
#nullable restore
#line 20 "C:\Users\asus\Desktop\kadSoftware\AspNETCore_MVC\TuristCoreProje\TuristCoreProje\Areas\Admin\Views\Role\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591