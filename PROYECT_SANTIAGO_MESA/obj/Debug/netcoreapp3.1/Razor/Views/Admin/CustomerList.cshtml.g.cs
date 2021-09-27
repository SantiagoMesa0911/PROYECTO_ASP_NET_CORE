#pragma checksum "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e68132942f64fb13ba76e14b3923afdd490786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CustomerList), @"mvc.1.0.view", @"/Views/Admin/CustomerList.cshtml")]
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
#line 1 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\_ViewImports.cshtml"
using PROYECT_SANTIAGO_MESA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\_ViewImports.cshtml"
using PROYECT_SANTIAGO_MESA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e68132942f64fb13ba76e14b3923afdd490786", @"/Views/Admin/CustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847e6a0da90a0db35b3271dbcd3b34c46240997f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PROYECT_SANTIAGO_MESA.Core.Entity.CustomerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
  
    ViewData["Title"] = "Lista Clientes";
    Layout = "~/Views/Shared/_adminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""page-wrapper"">
    <div class=""container-fluid"">
        <!-- Start Page Content -->
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Lista Clientes</h4>
                        <div class=""table-responsive m-t-40"">
                            <table id=""example23"" class=""display nowrap table table-hover  table-bordered"" cellspacing=""0"" width=""100%"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Email</th>
                                        <th>Phone</th>
                                        <th>Notes</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 29 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 32 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 33 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
                                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 34 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 35 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
                                       Write(item.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        \r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1705, "\"", 1776, 1);
#nullable restore
#line 38 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
WriteAttributeValue("", 1712, Url.Action("EditCustomer", "Admin", new {customerId = item.Id}), 1712, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-icon btn-warning btn-xs m-b-5\">\r\n                                                <i class=\"fa fa-edit\"></i>\r\n                                            </a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1998, "\"", 2071, 1);
#nullable restore
#line 41 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
WriteAttributeValue("", 2005, Url.Action("DeleteCustomer", "Admin", new {customerId = item.Id}), 2005, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Are you sure you want to Remove this customer?')"" class=""btn btn-icon btn-danger btn-xs m-b-5"">
                                                <i class=""fa fa-remove""></i>
                                            </a>
                                        </td>
                                    </tr>
");
#nullable restore
#line 46 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\CustomerList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End PAge Content -->
    </div>
</div>





");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PROYECT_SANTIAGO_MESA.Core.Entity.CustomerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591