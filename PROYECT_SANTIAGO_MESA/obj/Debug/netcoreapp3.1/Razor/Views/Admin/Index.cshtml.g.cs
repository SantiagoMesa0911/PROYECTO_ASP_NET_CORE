#pragma checksum "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc0ddf30a8a9e6b0bad3c439e24e9746b9cdd204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc0ddf30a8a9e6b0bad3c439e24e9746b9cdd204", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847e6a0da90a0db35b3271dbcd3b34c46240997f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROYECT_SANTIAGO_MESA.Core.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_adminLayout.cshtml";
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-wrapper"">
    <!-- Bread crumb -->
    <div class=""row page-titles"">
        <div class=""col-md-5 align-self-center"">
            <h3 class=""text-primary"">Dashboard</h3>
        </div>
        <div class=""col-md-7 align-self-center"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Home</a></li>
                <li class=""breadcrumb-item active"">Dashboard</li>
            </ol>
        </div>
    </div>
    <!-- End Bread crumb -->
    <!-- Container fluid  -->
    <div class=""container-fluid"">
        <!-- Start Page Content -->
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""card p-30"">
                    <div class=""media"">
                        <div class=""media-left meida media-middle"">
                            <span><i class=""fa fa-usd f-s-40 color-primary""></i></span>
                        </div>
                        <div class=""media-body media-text");
            WriteLiteral("-right\">\r\n                            <h2>");
#nullable restore
#line 33 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                           Write(Model.TotalSaleValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <p class=""m-b-0"">Ingresos totales</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""card p-30"">
                    <div class=""media"">
                        <div class=""media-left meida media-middle"">
                            <span><i class=""fa fa-shopping-cart f-s-40 color-success""></i></span>
                        </div>
                        <div class=""media-body media-text-right"">
                            <h2>");
#nullable restore
#line 46 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                           Write(Model.TotalSales);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <p class=""m-b-0"">Ventas Totales</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""card p-30"">
                    <div class=""media"">
                        <div class=""media-left meida media-middle"">
                            <span><i class=""fa fa-archive f-s-40 color-warning""></i></span>
                        </div>
                        <div class=""media-body media-text-right"">
                            <h2>");
#nullable restore
#line 59 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                           Write(Model.Products);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <p class=""m-b-0"">Productos Totales</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3"">
                <div class=""card p-30"">
                    <div class=""media"">
                        <div class=""media-left meida media-middle"">
                            <span><i class=""fa fa-user f-s-40 color-danger""></i></span>
                        </div>
                        <div class=""media-body media-text-right"">
                            <h2>");
#nullable restore
#line 72 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                           Write(Model.Customers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <p class=""m-b-0"">Clientes</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""card-title"">
                        <h4>Five Recent Sales </h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Code</th>
                                        <th>Fecha</th>
                                        <th>Precio Venta</th>
                                        <th>Estado</th>
                                        <th>Imprimir</th>
                                  ");
            WriteLiteral("  </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 99 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                     foreach (var item in Model.LastFiveSales)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 102 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 103 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                           Write(item.SaleCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 104 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                            Write(String.Format("{0:dd/MM/yyyy}", item.SalesDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 105 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                           Write(item.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n");
#nullable restore
#line 107 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                                 if (item.Status == "Due")
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <label class=\"label label-warning\">due</label>\r\n");
#nullable restore
#line 110 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                                 if (item.Status == "Paid")
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <label class=\"label label-success\">paid</label>\r\n");
#nullable restore
#line 115 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5423, "\"", 5496, 1);
#nullable restore
#line 119 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
WriteAttributeValue("", 5430, Url.Action("SaleInvoice","Sales", new {saleId = item.Id,style=1}), 5430, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Invoice 1\" class=\"btn btn-icon btn-primary btn-xs m-b-5\"><i class=\"fa fa-print\"> </i> </a>\r\n\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5649, "\"", 5722, 1);
#nullable restore
#line 121 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
WriteAttributeValue("", 5656, Url.Action("SaleInvoice","Sales", new {saleId = item.Id,style=2}), 5656, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Invoice 2\" class=\"btn btn-icon btn-primary btn-xs m-b-5\"><i class=\"fa fa-print\"> </i> </a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 124 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Admin\Index.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROYECT_SANTIAGO_MESA.Core.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
