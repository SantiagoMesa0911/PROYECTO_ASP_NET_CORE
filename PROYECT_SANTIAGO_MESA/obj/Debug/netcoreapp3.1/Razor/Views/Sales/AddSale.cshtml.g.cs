#pragma checksum "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cf809e409cead8b5fb270381c8f0b1859386cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_AddSale), @"mvc.1.0.view", @"/Views/Sales/AddSale.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf809e409cead8b5fb270381c8f0b1859386cf5", @"/Views/Sales/AddSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847e6a0da90a0db35b3271dbcd3b34c46240997f", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_AddSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
  
    ViewData["Title"] = "AddSale";
    Layout = "~/Views/Shared/_adminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    .bg_1 {
        background-color: green;
    }

    .bg_2 {
        background-color: gray;
    }


    .error_msg {
        color: #f00;
        display: none;
    }

    .table {
        /* width: 100%; */
        /* max-width: 100%; */
        margin-bottom: 0px;
    }
</style>
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/css/bootstrap-datepicker3.css"" rel=""stylesheet"" />

<div class=""page-wrapper"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-title"">

                    </div>
                    <div class=""card-body"">
                        <div class=""col-md-12"">
                            <div class=""form-inline"">
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""N");
            WriteLiteral("ame\">Cliente &nbsp  </label>\r\n                                        <select id=\"Customer\" class=\"form-control\" onchange=\"blankme(this.id)\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cf809e409cead8b5fb270381c8f0b1859386cf55634", async() => {
                WriteLiteral("Select Customer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                        <small id=""error_Customer"" class=""form-text error_msg"">Select customer from list</small>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""Code""> Code  &nbsp</label>
                                        ");
#nullable restore
#line 52 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
                                   Write(Html.TextBox("Code", null, new { @class = "form-control", @placeholder = "Enter Sale No", onkeyup = "blankme(this.id)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <small id=""error_Code"" class=""form-text error_msg col-md-offset-2 ""> Sale Code is Required</small>
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""Date""> Fecha  &nbsp</label>
                                        ");
#nullable restore
#line 59 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
                                   Write(Html.TextBox("Date", null, new { @class = "form-control mydatepicker", @placeholder = "Select Sale Date ", onchange = "blankme(this.id)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <small id=""error_Date"" class=""form-text error_msg col-md-offset-2 "">Sale Date is Required</small>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br /> <br />
                        <div class=""col-md-12"">
                            <label class=""col-md-2"">Buscar Productos</label>
                            <div class=""input-group input-group-default col-md-8"">
                                <span class=""input-group-btn""><button class=""btn btn-primary"" type=""submit""><i class=""ti-search""></i></button></span>
                                <input type=""text"" placeholder=""Search Product"" name=""Search"" id=""Search"" class=""form-control"">
                            </div>

                            <br />

                            <table class=""table table-hover col-md-12"" id=""detailsTable"">
                                <t");
            WriteLiteral(@"head>
                                    <tr>

                                        <th style=""width:280px"">Name</th>
                                        <th>Unit</th>
                                        <th>Quantity</th>
                                        <th>Amount</th>
                                        <th style=""width:20px""></th>

                                    </tr>
                                </thead>
                                <tbody id=""itemDetails""></tbody>
                                <tfoot>
                                    <tr>

                                        <td></td>
                                        <td></td>
                                        <td> <strong> Total:</strong> </td>
                                        <td> <strong id=""SubTotal"">  </strong> </td>
                                        <td></td>
                                    </tr>
                                </tfoot>
                  ");
            WriteLiteral(@"          </table>

                            <small id=""error_SubTotal"" class=""form-text error_msg"">Atleast add one item</small>
                            <br />
                            <br />

                            <div class=""row"">
                                <div class=""col-md-5"">

                                    <div class=""form-group"">
                                        <label for=""Date""> Método de pago : </label>
                                        ");
#nullable restore
#line 109 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
                                   Write(Html.DropDownList("Payment", new List<SelectListItem>
                                        {
                                            new SelectListItem() {Text = "Efectivo", Value="Cash"},
                                            new SelectListItem() {Text = "Tarjeta", Value="Check"},
                                        }, "Select Payment", new { @class = "form-control", onchange = "blankme(this.id)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <small id=""error_Payment"" class=""form-text error_msg"">Select Payment Method</small>
                                    </div>

                                    <div class=""form-group"">
                                        <label for=""Status""> Estado : </label>
                                        ");
#nullable restore
#line 119 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
                                   Write(Html.DropDownList("Status", new List<SelectListItem>
                                        {
                                            new SelectListItem() {Text = "Due", Value="Due"},
                                            new SelectListItem() {Text = "Paid", Value="Paid"},
                                        }, "Select Status", new { @class = "form-control", onchange = "blankme(this.id)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <small id=""error_Status"" class=""form-text error_msg"">Select Sale Status</small>
                                    </div>

                                    <div class=""form-group"">
                                        <label for=""Notes""> Notas: </label>
                                        ");
#nullable restore
#line 129 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
                                   Write(Html.TextArea("Notes", new { @class = "form-control", @rows = "5", @placeholder = "Enter Notes" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-md-3 col-md-offset-3""></div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <label for=""Discount""> Descuento : </label>
                                        ");
#nullable restore
#line 137 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
                                   Write(Html.TextBox("Discount", null, new { @class = "form-control", @Value = 0, @type = "number", @placeholder = "Discount Amount ", onchange = "DiscountAmount()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <small id=""error_Discount"" class=""form-text error_msg"">Discount can't be empty</small>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""GrandTotal""> Grand Total : </label>
                                        <input type=""text"" id=""GrandTotal"" class=""form-control"" readonly />
                                        <small id=""error_GrandTotal"" class=""form-text error_msg"">Total is empty</small>
                                    </div>
                                </div>
                            </div>

                            <div class=""form-horizontal"">
                                <label> </label>
                                <input id=""BtnSave"" class=""btn btn-success col-md-3 pull-right"" type=""submit"" value=""Save Sale"" />
                            </div>
                        </div>
                    </div>
          ");
            WriteLiteral("      </div>\r\n                <!-- panel-body -->\r\n            </div>\r\n            <!-- panel -->\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cf809e409cead8b5fb270381c8f0b1859386cf515906", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 164 "D:\PC\Desktop\Santiago\Estudios San\Sena\TERCER TRIMESTRE\.NET\PROYECT_SANTIAGO_MESA\Views\Sales\AddSale.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591