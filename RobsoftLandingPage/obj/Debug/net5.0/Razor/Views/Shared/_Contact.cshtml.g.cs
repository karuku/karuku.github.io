#pragma checksum "D:\Robsoft\Projects\RobsoftWebsite\RobsoftLandingPage\Views\Shared\_Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a60e8050b6bb2b8d2ece6f819736fe1ae3f25026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Contact), @"mvc.1.0.view", @"/Views/Shared/_Contact.cshtml")]
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
#line 1 "D:\Robsoft\Projects\RobsoftWebsite\RobsoftLandingPage\Views\_ViewImports.cshtml"
using RobsoftLandingPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Robsoft\Projects\RobsoftWebsite\RobsoftLandingPage\Views\_ViewImports.cshtml"
using RobsoftLandingPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60e8050b6bb2b8d2ece6f819736fe1ae3f25026", @"/Views/Shared/_Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb366eef2c427d983559946fd952bc6735d17fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("php-email-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section id=""contact"" class=""contact"">

    <div class=""container"" data-aos=""fade-up"">

        <header class=""section-header"">
            <h2>Contact</h2>
            <p>Contact Us</p>
        </header>

        <div class=""row gy-4"">

            <div class=""col-lg-6"">

                <div class=""row gy-4"">
                    <div class=""col-md-6"">
                        <div class=""info-box"">
                            <i class=""bi bi-geo-alt""></i>
                            <h3>Address</h3>
                            <p>A108 Kikuyu Street,<br>Kikuyu, KK 535022</p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""info-box"">
                            <i class=""bi bi-telephone""></i>
                            <h3>Call Us</h3>
                            <p>+254 759 681 763<br>+254 751 095 383</p>
                        </div>
                    </div>
                    <div class=");
            WriteLiteral(@"""col-md-6"">
                        <div class=""info-box"">
                            <i class=""bi bi-envelope""></i>
                            <h3>Email Us</h3>
                            <p>info@robsoftsolutions.co.ke<br>contact@robsoftsolutions.co.ke</p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""info-box"">
                            <i class=""bi bi-clock""></i>
                            <h3>Open Hours</h3>
                            <p>Monday - Friday<br>9:00AM - 05:00PM</p>
                            <p>Saturday<br>9:00AM - 01:00PM</p>
                        </div>
                    </div>
                </div>

            </div>

            <div class=""col-lg-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a60e8050b6bb2b8d2ece6f819736fe1ae3f250266159", async() => {
                WriteLiteral(@"
                    <div class=""row gy-4"">

                        <div class=""col-md-6"">
                            <input type=""text"" name=""name"" class=""form-control"" placeholder=""Your Name"" required>
                        </div>

                        <div class=""col-md-6 "">
                            <input type=""email"" class=""form-control"" name=""email"" placeholder=""Your Email"" required>
                        </div>

                        <div class=""col-md-12"">
                            <input type=""text"" class=""form-control"" name=""subject"" placeholder=""Subject"" required>
                        </div>

                        <div class=""col-md-12"">
                            <textarea class=""form-control"" name=""message"" rows=""6"" placeholder=""Message"" required></textarea>
                        </div>

                        <div class=""col-md-12 text-center"">
                            <div class=""loading"">Loading</div>
                            <div class=""erro");
                WriteLiteral(@"r-message""></div>
                            <div class=""sent-message"">Your message has been sent. Thank you!</div>

                            <button type=""submit"">Send Message</button>
                        </div>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>");
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