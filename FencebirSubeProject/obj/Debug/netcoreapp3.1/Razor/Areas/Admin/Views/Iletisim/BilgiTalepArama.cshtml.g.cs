#pragma checksum "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Iletisim_BilgiTalepArama), @"mvc.1.0.view", @"/Areas/Admin/Views/Iletisim/BilgiTalepArama.cshtml")]
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
#line 1 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\_ViewImports.cshtml"
using FencebirSubeProject.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\_ViewImports.cshtml"
using FencebirSubeProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e", @"/Areas/Admin/Views/Iletisim/BilgiTalepArama.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b575625314b6a8b2920e6151574b008e0a3d601e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Iletisim_BilgiTalepArama : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MesajAramaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control datatable-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("kt-form kt-form--fit mb-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
  var kullaniciGirisModel = ViewBag.KullaniciGirisData as KullaniciGirisModel; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
  
    ViewData["Title"] = "BilgiTalepArama";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex flex-row flex-column-fluid container"">
    <div class=""main d-flex flex-column flex-row-fluid"">
        <div class=""subheader py-2 py-lg-4 subheader-transparent"" id=""kt_subheader"">
            <div class=""container d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap"">
                <div class=""d-flex align-items-center flex-wrap mr-1"">
                    <div class=""d-flex align-items-baseline flex-wrap mr-5"">
                        <h5 class=""text-dark font-weight-bold my-1 mr-5"">Bilgi Talep Arama</h5>

                        <ul class=""breadcrumb breadcrumb-transparent breadcrumb-dot font-weight-bold p-0 my-2 font-size-sm"">
                            <li class=""breadcrumb-item"">
                                <a href=""/Admin/Iletisim"" class=""text-muted"">İletişim</a>
                            </li>
                            <li class=""breadcrumb-item"">
                                <a href=""/Admin/Iletisim/BilgiTalepArama"" class=""text-mute");
            WriteLiteral(@"d"">Bilgi Talep Arama</a>
                            </li>
                        </ul>
                    </div>
                </div>

                <div class=""d-flex align-items-center"">
                    <a href=""/Admin/Iletisim/BilgiTalepArama"" class=""btn btn-icon btn-circle btn-sm btn-light-success mr-1"" data-card-tool=""reload"">
                        <i class=""ki ki-reload icon-nm""></i>
                    </a>
                </div>
            </div>
        </div>

        <div class=""content flex-column-fluid"" id=""kt_content"">
            <div class=""card card-custom"">
                <div class=""card-header"">
                    <div class=""card-title"">
                        <span class=""card-icon"">
                            <i class=""flaticon2-delivery-package text-primary""></i>
                        </span>
                        <h3 class=""card-label"">Filtreleme Kriterleri</h3>
                    </div>
                </div>
                <div class=""");
            WriteLiteral("card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e8742", async() => {
                WriteLiteral("\r\n                        <div class=\"row mb-6\">\r\n                            <div class=\"col-lg-3 mb-lg-0 mb-6\">\r\n                                <label>Şube &amp; Temsilci:</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e9224", async() => {
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e9528", async() => {
                        WriteLiteral("Tümü");
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
                    WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
                                     foreach (var item in Model.SubeList)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e11191", async() => {
#nullable restore
#line 54 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
                                                                Write(item.SubeAdi);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
                                           WriteLiteral(item.SubeId);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 55 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 50 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.SubeId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "disabled", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
AddHtmlAttributeValue("", 2648, kullaniciGirisModel.SubeId!=1 ? "disabled" : null, 2648, 52, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
                                 if (kullaniciGirisModel.SubeId != 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e15786", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 59 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.SubeId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 60 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <div class=\"col-lg-3 mb-lg-0 mb-6\">\r\n                                <label>Mesaj İçerik:</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8804d9da5c9d5bbd516deee6dc41da1ca63b1b6e17968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 64 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Areas\Admin\Views\Iletisim\BilgiTalepArama.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.MesajIcerik);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""row mt-8"">
                            <div class=""col-lg-12"">
                                <button type=""button"" class=""btn btn-primary btn-primary--icon"" onclick=""javascript: ara();"">
                                    <span>
                                        <i class=""la la-search""></i>
                                        <span>Ara</span>
                                    </span>
                                </button>&#160;&#160;
                                <button type=""button"" class=""btn btn-secondary btn-secondary--icon"" onclick='location.reload();'>
                                    <span>
                                        <i class=""la la-close""></i>
                                        <span>Temizle</span>
                                    </span>
                                </button>
                            </div>
                        ");
                WriteLiteral("</div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    <table id=""dtArama"" class=""table table-bordered table-hover table-checkable"">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Şube</th>
                                <th>Mesaj İçerik</th>
                                <th>Gönderim Tarih</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>ID</th>
                                <th>Şube</th>
                                <th>Mesaj İçerik</th>
                                <th>Gönderim Tarih</th>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        function ara() {
            var data = $('#_form').serializeObject();

            $('#dtArama').DataTable().destroy();

            var table = $('#dtArama').DataTable({
                processing: true,
                serverSide: true,
                filter: false,
                responsive: true,
                orderMulti: false,
                autoWidth: false,
                ordering: false,
                //fixedColumns: true,
                ajax: {
                    url: '/Admin/Iletisim/BilgiTalepArama',
                    type: 'post',
                    datatype: ""json"",
                    dataSrc: ""data"",
                    defaultContent: """",
                    data: data,
                    beforeSend: function () {
                        showLoading('dtArama');
                    },
                    complete: function () {
                        hideLoading('dtArama');
                    },
        ");
                WriteLiteral(@"            error: function (error) {
                        hideLoading('dtArama');

                        Swal.fire(
                            ""Hata"",
                            ""İşlem sırasında hata oluştu. "" + error,
                            ""error""
                        )
                    }
                },
                columns: [
                    { data: 'MesajId', defaultContent: '' },
                    { data: 'SubeAdi', defaultContent: '' },
                    { data: 'MesajIcerik', defaultContent: '' },
                    { data: 'GonderimTarihi', defaultContent: '' },
                ],
                columnDefs: [
                    { targets: 0, width: '5%' },
                    { targets: 1, width: '15%' },
                    { targets: 2, width: '70%' },
                    { targets: 3, width: '10%' },
                ],
                dom: `<'row'<'col-sm-6 text-left'f><'col-sm-6 text-right'B>>
                          <'row'<'col-sm-12't");
                WriteLiteral(@"r>>
                          <'row'<'col-sm-12 col-md-5'i><'col-sm-12 col-md-7 dataTables_pager'lp>>`,
                lengthMenu: [[5, 25, 50], [5, 25, 50]],
                buttons: [
                    {
                        extend: 'print',
                        text: 'Yazdır'
                    },
                    {
                        extend: 'excelHtml5',
                        text: 'Excel'
                    },
                    {
                        extend: 'pdfHtml5',
                        text: 'Pdf'
                    }
                ],
                language: {
                    url: 'https://cdn.datatables.net/plug-ins/1.10.21/i18n/Turkish.json'
                }
            });
        };

        function showLoading(id) {
            KTApp.block(document.getElementById(id), {
                overlayColor: '#000000',
                state: 'danger',
                message: 'Lütfen bekleyin...'
            });
        };

        ");
                WriteLiteral("function hideLoading(id) {\r\n            KTApp.unblock(document.getElementById(id));\r\n        };\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MesajAramaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
