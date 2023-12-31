#pragma checksum "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ae84a520a81647650d8b4b2fbfa1619e094d1ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Urun;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae84a520a81647650d8b4b2fbfa1619e094d1ce", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f13c5022996f949c9e89ef2804a674a5da4248", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Personel Adı</th>
        <th>Personel Soyadı</th>
        <th>Personel Ünvan</th>
        <th>Personel Yaşı</th>
        <th>Sil</th>
        <th>Güncelle</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 725, "\"", 765, 2);
            WriteAttributeValue("", 732, "/Employee/DeleteEmployee/", 732, 25, true);
#nullable restore
#line 26 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
WriteAttributeValue("", 757, item.ID, 757, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\" >Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 896, 2);
            WriteAttributeValue("", 863, "/Employee/UpdateEmployee/", 863, 25, true);
#nullable restore
#line 27 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
WriteAttributeValue("", 888, item.ID, 888, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n                    <td><a href=\"#\" class=\"btn mb-1 btn-rounded btn-outline-warning\">Detaylar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\PC_3829\Desktop\SerilogProjemGüncel\Frontend\WebUI\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Employee/AddEmployee/\" class=\" btn mb-1 btn-rounded btn-outline-info\">Yeni Personel Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
