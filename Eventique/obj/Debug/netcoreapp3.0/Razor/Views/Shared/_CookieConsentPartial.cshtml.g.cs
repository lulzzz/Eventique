<<<<<<< HEAD
#pragma checksum "E:\finial\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c556b2727fd18297cbb35bc6dda0e6d21b1be5c1"
=======
#pragma checksum "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c556b2727fd18297cbb35bc6dda0e6d21b1be5c1"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CookieConsentPartial), @"mvc.1.0.view", @"/Views/Shared/_CookieConsentPartial.cshtml")]
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
<<<<<<< HEAD
#line 1 "E:\finial\Eventique\Eventique\Views\_ViewImports.cshtml"
=======
#line 1 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\_ViewImports.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\finial\Eventique\Eventique\Views\_ViewImports.cshtml"
=======
#line 2 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\_ViewImports.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
using Eventique.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 1 "E:\finial\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 1 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c556b2727fd18297cbb35bc6dda0e6d21b1be5c1", @"/Views/Shared/_CookieConsentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CookieConsentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "E:\finial\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 3 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
  
    var consentFeature = Context.Features.Get<ITrackingConsentFeature>();
    var showBanner = !consentFeature?.CanTrack ?? false;
    var cookieString = consentFeature?.CreateConsentCookie();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 9 "E:\finial\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 9 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
 if (showBanner)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"cookieConsent\" class=\"alert alert-info alert-dismissible fade show\" role=\"alert\">\r\n        Use this space to summarize your privacy and cookie use policy. ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c556b2727fd18297cbb35bc6dda0e6d21b1be5c14340", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c556b2727fd18297cbb35bc6dda0e6d21b1be5c14538", async() => {
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
                WriteLiteral("Learn More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\r\n        <button type=\"button\" class=\"accept-policy close\" data-dismiss=\"alert\" aria-label=\"Close\" data-cookie-string=\"");
#nullable restore
<<<<<<< HEAD
#line 13 "E:\finial\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 13 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
                                                                                                                 Write(cookieString);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            <span aria-hidden=""true"">Accept</span>
        </button>
    </div>
    <script>
        (function () {
            var button = document.querySelector(""#cookieConsent button[data-cookie-string]"");
            button.addEventListener(""click"", function (event) {
                document.cookie = button.dataset.cookieString;
            }, false);
        })();
    </script>
");
#nullable restore
<<<<<<< HEAD
#line 25 "E:\finial\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
=======
#line 25 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Shared\_CookieConsentPartial.cshtml"
>>>>>>> 8e7f89a021640d4a84943d5a54455e17959c8ec0
}

#line default
#line hidden
#nullable disable
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
