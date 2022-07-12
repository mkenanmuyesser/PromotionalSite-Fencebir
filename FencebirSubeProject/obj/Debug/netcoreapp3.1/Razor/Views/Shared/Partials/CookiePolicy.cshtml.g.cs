#pragma checksum "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Shared\Partials\CookiePolicy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "346114f1b1e464654818fc8a6551f5baf97a5abc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials_CookiePolicy), @"mvc.1.0.view", @"/Views/Shared/Partials/CookiePolicy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346114f1b1e464654818fc8a6551f5baf97a5abc", @"/Views/Shared/Partials/CookiePolicy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f5c49eac9640d08c591eaeed1f837ad88f8fee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials_CookiePolicy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Shared\Partials\CookiePolicy.cshtml"
  
    var controller = @ViewContext.RouteData.Values["Controller"].ToString();
    var action = @ViewContext.RouteData.Values["Action"].ToString();
    var id = @ViewContext.RouteData.Values["Id"] == null ? "" : @ViewContext.RouteData.Values["Id"].ToString();
    var genelLink = "/" + controller + (id == "" ? "" : "/" + id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    #cookieConsent {
        background-color: rgba(20,20,20,0.8);
        min-height: 26px;
        font-size: 14px;
        color: #ccc;
        line-height: 26px;
        padding: 8px 0 8px 30px;
        position: fixed;
        bottom: 0;
        left: 0;
        right: 0;
        display: none;
        z-index: 9999;
    }

        #cookieConsent a {
            color: #4B8EE7;
            text-decoration: none;
        }

    #closeCookieConsent {
        float: right;
        display: inline-block;
        cursor: pointer;
        height: 20px;
        width: 20px;
        margin: -15px 0 0 0;
        font-weight: bold;
    }

        #closeCookieConsent:hover {
            color: #FFF;
        }

    #cookieConsent a.cookieConsentOK {
        background-color: #F1D600;
        color: #000;
        display: inline-block;
        border-radius: 5px;
        padding: 0 20px;
        cursor: pointer;
        float: right;
        margin:");
            WriteLiteral(@" 0 60px 0 10px;
    }

        #cookieConsent a.cookieConsentOK:hover {
            background-color: #E0C91F;
        }
</style>

<div id=""cookieConsent"">
    <div id=""closeCookieConsent"">x</div>
    Sizlere daha iyi bir hizmet sunabilmek için sitemizde çerezlerden faydalanıyoruz. Sitemizi kullanmaya devam ederek çerezleri kullanmamıza izin vermiş oluyorsunuz. Daha fazla bilgi için  <a");
            BeginWriteAttribute("href", " href=\"", 1759, "\"", 1794, 2);
#nullable restore
#line 61 "D:\Programlar\FencebirSubeProject\FencebirSubeProject\Views\Shared\Partials\CookiePolicy.cshtml"
WriteAttributeValue("", 1766, genelLink, 1766, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1778, "/CerezPolitikasi", 1778, 16, true);
            EndWriteAttribute();
            WriteLiteral(@">Çerez Politikası</a> <a class=""cookieConsentOK"">Anladım</a>
</div>

<script type=""text/javascript"">
    $(document).ready(function () {
        setTimeout(function () {
            $(""#cookieConsent"").fadeIn(200);
        }, 4000);
        $(""#closeCookieConsent, .cookieConsentOK"").click(function () {
            $(""#cookieConsent"").fadeOut(200);
        });
    });
</script>");
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
