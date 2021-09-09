#pragma checksum "C:\Users\Filipe\Documents\Projetos\fusariose\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd0c3c4626594f926ec3e537b70f14225884ea5"
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
#line 1 "C:\Users\Filipe\Documents\Projetos\fusariose\Views\_ViewImports.cshtml"
using fusariose;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Filipe\Documents\Projetos\fusariose\Views\_ViewImports.cshtml"
using fusariose.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd0c3c4626594f926ec3e537b70f14225884ea5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682fd8f1be028bc46deaedf7ef6459cd68e627b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Filipe\Documents\Projetos\fusariose\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""content"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card card-chart"">
                    <div class=""card-header "">
                        <div class=""row"">
                            <div class=""col-sm-6 text-left"">
                                <h5 class=""card-category"">Total Shipments</h5>
                                <h2 class=""card-title"">Performance</h2>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""btn-group btn-group-toggle float-right"" data-toggle=""buttons"">
                                    <label class=""btn btn-sm btn-primary btn-simple active"" id=""0"">
                                        <input type=""radio"" name=""options"" checked>
                                        <span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Accounts</span>
                                        <span class=""d");
            WriteLiteral(@"-block d-sm-none"">
                                            <i class=""tim-icons icon-single-02""></i>
                                        </span>
                                    </label>
                                    <label class=""btn btn-sm btn-primary btn-simple"" id=""1"">
                                        <input type=""radio"" class=""d-none d-sm-none"" name=""options"">
                                        <span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Purchases</span>
                                        <span class=""d-block d-sm-none"">
                                            <i class=""tim-icons icon-gift-2""></i>
                                        </span>
                                    </label>
                                    <label class=""btn btn-sm btn-primary btn-simple"" id=""2"">
                                        <input type=""radio"" class=""d-none"" name=""options"">
                                        <span class=""d-none d-sm-b");
            WriteLiteral(@"lock d-md-block d-lg-block d-xl-block"">Sessions</span>
                                        <span class=""d-block d-sm-none"">
                                            <i class=""tim-icons icon-tap-02""></i>
                                        </span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""chartBig1""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h5 class=""card-category"">Total Shipments</h5>
                        <h3 class=""card-title""><i class=""tim-icons icon-be");
            WriteLiteral(@"ll-55 text-primary""></i> 763,215</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""chartLinePurple""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h5 class=""card-category"">Daily Sales</h5>
                        <h3 class=""card-title""><i class=""tim-icons icon-delivery-fast text-info""></i> 3,500€</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""CountryChart""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card card-chart"">
  ");
            WriteLiteral(@"                  <div class=""card-header"">
                        <h5 class=""card-category"">Completed Tasks</h5>
                        <h3 class=""card-title""><i class=""tim-icons icon-send text-success""></i> 12,100K</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""chartLineGreen""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6 col-md-12"">
                <div class=""card card-tasks"">
                    <div class=""card-header "">
                        <h6 class=""title d-inline"">Tasks(5)</h6>
                        <p class=""card-category d-inline"">today</p>
                        <div class=""dropdown"">
                            <button type=""button"" class=""btn btn-link dropdown-toggle btn-icon"" data-toggle=""dropdown"">
               ");
            WriteLiteral(@"                 <i class=""tim-icons icon-settings-gear-63""></i>
                            </button>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuLink"">
                                <a class=""dropdown-item"" href=""#pablo"">Action</a>
                                <a class=""dropdown-item"" href=""#pablo"">Another action</a>
                                <a class=""dropdown-item"" href=""#pablo"">Something else</a>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body "">
                        <div class=""table-full-width table-responsive"">
                            <table class=""table"">
                                <tbody>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-labe");
            WriteLiteral("l\">\r\n                                                    <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 6293, "\"", 6301, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Update the Documentation</p>
                                            <p class=""text-muted"">Dwuamish Head, Seattle, WA 8:47 AM</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 7137, "\"", 7145, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 7773, "\"", 7781, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 7782, "\"", 7792, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">GDPR Compliance</p>
                                            <p class=""text-muted"">The GDPR is a regulation that requires businesses to protect the personal data and privacy of Europe citizens for transactions that occur within EU member states.</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 8747, "\"", 8755, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 9383, "\"", 9391, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Solve the issues</p>
                                            <p class=""text-muted"">Fifty percent of all respondents said they would be more likely to shop at a company </p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 10270, "\"", 10278, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 10906, "\"", 10914, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Release v2.0.0</p>
                                            <p class=""text-muted"">Ra Ave SW, Seattle, WA 98116, SUA 11:19 AM</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 11748, "\"", 11756, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 12384, "\"", 12392, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Export the processed files</p>
                                            <p class=""text-muted"">The report also shows that consumers will not easily forgive a company once a breach exposing their personal data occurs. </p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 13318, "\"", 13326, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 13954, "\"", 13962, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Arival at export process</p>
                                            <p class=""text-muted"">Capitol Hill, Seattle, WA 12:34 AM</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 14798, "\"", 14806, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12"">
                <div class=""card "">
                    <div class=""card-header"">
                        <h4 class=""card-title""> Simple Table</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table tablesorter """);
            BeginWriteAttribute("id", " id=\"", 15666, "\"", 15671, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <thead class="" text-primary"">
                                    <tr>
                                        <th>
                                            Name
                                        </th>
                                        <th>
                                            Country
                                        </th>
                                        <th>
                                            City
                                        </th>
                                        <th class=""text-center"">
                                            Salary
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            Dakota Rice
                                        </td>
 ");
            WriteLiteral(@"                                       <td>
                                            Niger
                                        </td>
                                        <td>
                                            Oud-Turnhout
                                        </td>
                                        <td class=""text-center"">
                                            $36,738
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Minerva Hooper
                                        </td>
                                        <td>
                                            Curaçao
                                        </td>
                                        <td>
                                            Sinaai-Waas
                                        </td>
                              ");
            WriteLiteral(@"          <td class=""text-center"">
                                            $23,789
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Sage Rodriguez
                                        </td>
                                        <td>
                                            Netherlands
                                        </td>
                                        <td>
                                            Baileux
                                        </td>
                                        <td class=""text-center"">
                                            $56,142
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Philip Chaney");
            WriteLiteral(@"
                                        </td>
                                        <td>
                                            Korea, South
                                        </td>
                                        <td>
                                            Overland Park
                                        </td>
                                        <td class=""text-center"">
                                            $38,735
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Doris Greene
                                        </td>
                                        <td>
                                            Malawi
                                        </td>
                                        <td>
                                            Feldkirchen in Kärnten
           ");
            WriteLiteral(@"                             </td>
                                        <td class=""text-center"">
                                            $63,542
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Mason Porter
                                        </td>
                                        <td>
                                            Chile
                                        </td>
                                        <td>
                                            Gloucester
                                        </td>
                                        <td class=""text-center"">
                                            $78,615
                                        </td>
                                    </tr>
                                    <tr>
                                        <t");
            WriteLiteral(@"d>
                                            Jon Porter
                                        </td>
                                        <td>
                                            Portugal
                                        </td>
                                        <td>
                                            Gloucester
                                        </td>
                                        <td class=""text-center"">
                                            $98,615
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
 </div>
");
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
