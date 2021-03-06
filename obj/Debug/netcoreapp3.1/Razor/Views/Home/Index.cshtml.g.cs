#pragma checksum "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa818bf537dc3866e325a44512579c712b35a336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\_ViewImports.cshtml"
using WebSiteVisitorsProject4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\_ViewImports.cshtml"
using WebSiteVisitorsProject4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa818bf537dc3866e325a44512579c712b35a336", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5e0a1f92c04f3b9b951495a23ac4e4efcdb972", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteVisitorsProject4.Models.Sites>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Web Site Visitor Project";

    var visiters = 0;
    Dictionary<string, int> visitedSitesCountry = new Dictionary<string, int>();
    Dictionary<string, int> visitedSites = new Dictionary<string, int>();
    Dictionary<string, int> sitesDateTime = new Dictionary<string, int>();



    foreach (var item in Model.sites)
    {

        //Toplam Ziyaretçi Sayısı

        visiters++;

        //En çok Ziyaretçinin Geldiği Ülke

        if (!visitedSitesCountry.ContainsKey(item.sitesCountry))
        {
            visitedSitesCountry[item.sitesCountry] = 1;
        }
        else
        {
            visitedSitesCountry[item.sitesCountry] = visitedSitesCountry[item.sitesCountry] + 1;
        }

        //Günlük Sayfa Görüntüleme Sayıları

        if (!visitedSites.ContainsKey(item.sitesName))
        {
            visitedSites[item.sitesName] = 1;
        }
        else
        {
            visitedSites[item.sitesName] = visitedSites[item.sitesName] + 1;
        }

        //Günlük Sayfa Görüntüleme Sayıları

        DateTime tempDate = DateTime.ParseExact(item.sitesDate, "d.MM.yyyy HH:mm:ss", null);
        tempDate = tempDate.Date;
        item.sitesDate = tempDate.ToString();

        if (!sitesDateTime.ContainsKey(item.sitesDate))
        {
            sitesDateTime[item.sitesDate] = 1;
        }
        else
        {
            sitesDateTime[item.sitesDate] = sitesDateTime[item.sitesDate] + 1;
        }
    }

    var maxCountryValue = visitedSitesCountry.Values.Max();
    var maxCountryKey = visitedSitesCountry.FirstOrDefault(x => x.Value == maxCountryValue).Key;

    // Tarih Aralığı Belirterek Filtreleme
    /*
    DateTime start = new DateTime(2020, 12, 10); //start
    DateTime stop = new DateTime(2020, 12, 30); //finish
    foreach (var item in sitesDateTime)
    {
        DateTime tDate = DateTime.ParseExact(item.Key, "d.MM.yyyy HH:mm:ss", null);
        tDate = tDate.Date;
        if (tDate < start || tDate > stop)
        {

            sitesDateTime.Remove(tDate.ToString());
        }
    }
    */

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <p><b>Toplam ziyaretçi sayısı:</b> ");
#nullable restore
#line 78 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                                  Write(visiters);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>En çok ziyaretçinin geldiği ülkenin ziyaretçi sayısı:</b> ");
#nullable restore
#line 79 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                                                               Write(maxCountryValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p><b>En çok ziyaretçinin geldiği ülke:</b> ");
#nullable restore
#line 80 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                                           Write(maxCountryKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Sayfa Görüntülenme Sayıları</h5>\r\n\r\n    <table style=\"width:40%\">\r\n        <tr>\r\n            <th>Sayfa</th>\r\n            <th>Görüntülenme Sayısı</th>\r\n        </tr>\r\n        <tbody>\r\n");
#nullable restore
#line 89 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
             foreach (var item in visitedSites)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 93 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 96 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 99 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <h5>Günlük Sayfa Görüntüleme Sayıları</h5>\r\n\r\n    <div>\r\n        <b>Başlangıç Tarihi</b>\r\n        <b style=\"padding-left:40px;\">Bitiş Tarihi</b>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa818bf537dc3866e325a44512579c712b35a3368208", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input type=\"date\" value=\"2020-12-04\" >\r\n            <input type=\"date\" value=\"2021-01-03\" >\r\n            <input type=\"submit\" value=\"Filtrele\" class=\"btn btn-success\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <br />\r\n    <table style=\"width:40%\">\r\n        <tr>\r\n            <th>Tarih</th>\r\n            <th>Ziyaretçi Sayısı</th>\r\n        </tr>\r\n        <tbody>\r\n");
#nullable restore
#line 123 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
             foreach (var item in sitesDateTime)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 127 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 130 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 133 "C:\Users\cagrii\Desktop\Project\WebSiteVisitorsProject4\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteVisitorsProject4.Models.Sites> Html { get; private set; }
    }
}
#pragma warning restore 1591
