#pragma checksum "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e407427ee9e96dd4508dd00f1b2a16b07967248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kurumsal_Iletisim), @"mvc.1.0.view", @"/Views/Kurumsal/Iletisim.cshtml")]
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
#line 1 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\_ViewImports.cshtml"
using FencebirSubeProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\_ViewImports.cshtml"
using FencebirSubeProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e407427ee9e96dd4508dd00f1b2a16b07967248", @"/Views/Kurumsal/Iletisim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f5c49eac9640d08c591eaeed1f837ad88f8fee", @"/Views/_ViewImports.cshtml")]
    public class Views_Kurumsal_Iletisim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IletisimViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Kurumsal/Partials/IletisimTalep.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
  
    ViewData["Title"] = "İletişim";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""inner-header divider parallax layer-overlay overlay-dark-5"" data-bg-img=""/Uploads/TopBanner/TopBanner_6.jpg"">
    <div class=""container pt-70 pb-20"">
        <div class=""section-content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h2 class=""title text-white"">İLETİŞİM</h2>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""divider"">
    <div class=""container pt-0"">
        <div class=""row mb-60 bg-deep"">
            <div class=""col-sm-12 col-md-4"">
                <div class=""contact-info text-center pt-60 pb-60 border-right"">
                    <i class=""fa fa-phone font-36 mb-10 text-theme-colored""></i>
                    <h4>Telefon/Fax</h4>
");
#nullable restore
#line 26 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                     if (!string.IsNullOrEmpty(Model.SirketTelefon1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"text-gray\">Telefon: ");
#nullable restore
#line 28 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                                                  Write(Model.SirketTelefon1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 29 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                     if (!string.IsNullOrEmpty(Model.SirketTelefon2))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"text-gray\">Telefon: ");
#nullable restore
#line 32 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                                                  Write(Model.SirketTelefon2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 33 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                     if (!string.IsNullOrEmpty(Model.SirketFax1))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"text-gray\">Fax: ");
#nullable restore
#line 36 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                                              Write(Model.SirketFax1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 37 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                     if (!string.IsNullOrEmpty(Model.SirketFax2))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6 class=\"text-gray\">Fax: ");
#nullable restore
#line 40 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                                              Write(Model.SirketFax2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 41 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-sm-12 col-md-4"">
                <div class=""contact-info text-center  pt-60 pb-60 border-right"">
                    <i class=""fa fa-map-marker font-36 mb-10 text-theme-colored""></i>
                    <h4>Adres</h4>
                    <h6 class=""text-gray"">");
#nullable restore
#line 48 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                                     Write(Model.SirketAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                </div>
            </div>
            <div class=""col-sm-12 col-md-4"">
                <div class=""contact-info text-center  pt-60 pb-60"">
                    <i class=""fa fa-envelope font-36 mb-10 text-theme-colored""></i>
                    <h4>E-posta</h4>
                    <h6 class=""text-gray""><a");
            BeginWriteAttribute("href", " href=\"", 2365, "\"", 2398, 2);
            WriteAttributeValue("", 2372, "mailto:", 2372, 7, true);
#nullable restore
#line 55 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
WriteAttributeValue("", 2379, Model.SirketEposta, 2379, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
                                                                          Write(Model.SirketEposta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row pt-10\">\r\n            <div class=\"col-md-5\">\r\n                <h4 class=\"mt-0 mb-30 line-bottom\">Bize Ulaşın</h4>\r\n                <div>\r\n                    ");
#nullable restore
#line 63 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
               Write(Html.Raw(Model.SirketMapCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e407427ee9e96dd4508dd00f1b2a16b0796724810138", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 67 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Kurumsal\Iletisim.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.IletisimTalepData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IletisimViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
