#pragma checksum "C:\Users\Filipe\Documents\Projetos\fusariose\Views\Cliente\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceca3c574312fb2ead9b079f4c13110e701a60da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Cadastrar), @"mvc.1.0.view", @"/Views/Cliente/Cadastrar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceca3c574312fb2ead9b079f4c13110e701a60da", @"/Views/Cliente/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682fd8f1be028bc46deaedf7ef6459cd68e627b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Filipe\Documents\Projetos\fusariose\Views\Cliente\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-8"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5 class=""title"">Edit Profile</h5>
                </div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceca3c574312fb2ead9b079f4c13110e701a60da3758", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-5 pr-md-1"">
                                <div class=""form-group"">
                                    <label>Company (disabled)</label>
                                    <input type=""text"" class=""form-control""");
                BeginWriteAttribute("disabled", " disabled=\"", 659, "\"", 670, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Company"" value=""Creative Code Inc."">
                                </div>
                            </div>
                            <div class=""col-md-3 px-md-1"">
                                <div class=""form-group"">
                                    <label>Username</label>
                                    <input type=""text"" class=""form-control"" placeholder=""Username"" value=""michael23"">
                                </div>
                            </div>
                            <div class=""col-md-4 pl-md-1"">
                                <div class=""form-group"">
                                    <label for=""exampleInputEmail1"">Email address</label>
                                    <input type=""email"" class=""form-control"" placeholder=""mike@email.com"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6 pr-md");
                WriteLiteral(@"-1"">
                                <div class=""form-group"">
                                    <label>First Name</label>
                                    <input type=""text"" class=""form-control"" placeholder=""Company"" value=""Mike"">
                                </div>
                            </div>
                            <div class=""col-md-6 pl-md-1"">
                                <div class=""form-group"">
                                    <label>Last Name</label>
                                    <input type=""text"" class=""form-control"" placeholder=""Last Name"" value=""Andrew"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label>Address</label>
                                    <input type=""text"" class=""form-control"" placeholder=""");
                WriteLiteral(@"Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-4 pr-md-1"">
                                <div class=""form-group"">
                                    <label>City</label>
                                    <input type=""text"" class=""form-control"" placeholder=""City"" value=""Mike"">
                                </div>
                            </div>
                            <div class=""col-md-4 px-md-1"">
                                <div class=""form-group"">
                                    <label>Country</label>
                                    <input type=""text"" class=""form-control"" placeholder=""Country"" value=""Andrew"">
                                </div>
                            </div>
                            <div class=""col-md-4 pl-md-1"">
          ");
                WriteLiteral(@"                      <div class=""form-group"">
                                    <label>Postal Code</label>
                                    <input type=""number"" class=""form-control"" placeholder=""ZIP Code"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-8"">
                                <div class=""form-group"">
                                    <label>About Me</label>
                                    <textarea rows=""4"" cols=""80"" class=""form-control"" placeholder=""Here can be your description"" value=""Mike"">Lamborghini Mercy, Your chick she so thirsty, I'm in that two seat Lambo.</textarea>
                                </div>
                            </div>
                        </div>
                    ");
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
            WriteLiteral(@"
                </div>
                <div class=""card-footer"">
                    <button type=""submit"" class=""btn btn-fill btn-primary"">Save</button>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card card-user"">
                <div class=""card-body"">
                    <p class=""card-text"">
                        <div class=""author"">
                            <div class=""block block-one""></div>
                            <div class=""block block-two""></div>
                            <div class=""block block-three""></div>
                            <div class=""block block-four""></div>
                            <a href=""javascript:void(0)"">
                                <img class=""avatar"" src=""../assets/img/emilyz.jpg"" alt=""..."">
                                <h5 class=""title"">Mike Andrew</h5>
                            </a>
                            <p class=""description"">
                             ");
            WriteLiteral(@"   Ceo/Co-Founder
                            </p>
                        </div>
                    </p>
                    <div class=""card-description"">
                        Do not be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""button-container"">
                        <button href=""javascript:void(0)"" class=""btn btn-icon btn-round btn-facebook"">
                            <i class=""fab fa-facebook""></i>
                        </button>
                        <button href=""javascript:void(0)"" class=""btn btn-icon btn-round btn-twitter"">
                            <i class=""fab fa-twitter""></i>
                        </button>
                        <button href=""javascript:void(0)"" class=""btn btn-icon btn-round btn-google"">
               ");
            WriteLiteral("             <i class=\"fab fa-google-plus\"></i>\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
