#pragma checksum "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec725fb16122bfedadf219a73341dada3a7afa5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestPhoView), @"mvc.1.0.view", @"/Views/Home/TestPhoView.cshtml")]
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
#line 1 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec725fb16122bfedadf219a73341dada3a7afa5e", @"/Views/Home/TestPhoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestPhoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photographer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/GetAllReviews.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jqueryui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
  
    ViewData["Title"] = "TestPhoView";
    Layout = "~/Views/Shared/_phoViewLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec725fb16122bfedadf219a73341dada3a7afa5e5889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<div id=""colorlib-main"">
    <div class=""hero-wrap js-fullheight"" id=""AboutSEC"" style=""background-image: url(/Images/bg_1.jpg);"" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""js-fullheight d-flex justify-content-center align-items-center"">
            <div class=""col-md-8 text text-center"">
                <div class=""img mb-4""");
            BeginWriteAttribute("style", " style=\"", 590, "\"", 638, 4);
            WriteAttributeValue("", 598, "background-image:", 598, 17, true);
            WriteAttributeValue(" ", 615, "url(", 616, 5, true);
#nullable restore
#line 16 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 620, Model.ImagePath, 620, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 636, ");", 636, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"desc\">\r\n                    <h2 class=\"subheading\">Hello I\'m</h2>\r\n                    <h1 class=\"mb-4\">");
#nullable restore
#line 19 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                Write(Model.Ph_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    <p class=""mb-4"">I am A Blogger Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                    <p><a href=""#"" class=""btn-custom"">More About Me <span class=""ion-ios-arrow-forward""></span></a></p>
                </div>
            </div>
        </div>
    </div>
    <section class=""ftco-section"" id=""GallerySEC"">
        <div class=""container"">
            <div class=""row justify-content-center mb-5 pb-2"">
                <div class=""col-md-7 heading-section text-center ftco-animate"">
                    <h2 class=""mb-4"">Alubms</h2>
                    <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 36 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                     if (Model.ListAlbum != null)
                    {
                        int j = 0;
                        foreach (var item in Model.ListAlbum)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4\">\r\n                                <div class=\"blog-entry ftco-animate\">\r\n                                    <div src=\"#\" class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 2177, "\"", 2237, 4);
            WriteAttributeValue("", 2185, "background-image:", 2185, 17, true);
            WriteAttributeValue(" ", 2202, "url(", 2203, 5, true);
#nullable restore
#line 43 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 2207, item.MyProperty[j].Img_Path, 2207, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2235, ");", 2235, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2238, "\"", 2311, 8);
            WriteAttributeValue("", 2248, "openModal(\'myModal\'+\'", 2248, 21, true);
            WriteAttributeValue(" ", 2269, "\'+", 2270, 3, true);
#nullable restore
#line 43 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 2272, j, 2272, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2274, ",", 2275, 2, true);
            WriteAttributeValue(" ", 2276, "\'mySlides\'+\'", 2277, 13, true);
            WriteAttributeValue(" ", 2289, "\'+", 2290, 3, true);
#nullable restore
#line 43 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 2292, j, 2292, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2294, ");currentSlide(1)", 2294, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    <div class=""text text-2 pt-2 mt-3"">
                                        <span class=""category mb-3 d-block""><a href=""#"">Technology</a></span>
                                        <h3 class=""mb-4""><a href=""#"">");
#nullable restore
#line 46 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                Write(item.Al_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                        <p class=""mb-4"">Even the all-powerful Pointing has no control about the blind texts it is an almost</p>
                                        <div class=""author mb-4 d-flex align-items-center"">
                                            <a href=""#"" class=""img"" style=""background-image: url(/Images/person_2.jpg);""></a>
                                            <div class=""ml-3 info"">
                                                <span>Written by</span>
                                                <h3><a href=""#"">Dave Lewis</a>, <span>Nov. 28, 2018</span></h3>
                                            </div>
                                        </div>
                                        <div class=""meta-wrap align-items-center"">
                                            <div class=""half order-md-last"">
                                                <p class=""meta"">
                                                    <span><i clas");
            WriteLiteral(@"s=""icon-heart""></i>3</span>
                                                    <span><i class=""icon-eye""></i>100</span>
                                                    <span><i class=""icon-comment""></i>5</span>
                                                </p>
                                            </div>
                                            <div class=""half"">
                                                <p><a href=""#"" class=""btn py-2"">Continue Reading <span class=""ion-ios-arrow-forward""></span></a></p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 70 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                            j++;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <!------------------------ The Modal/Lightbox ------------------------------>\r\n");
#nullable restore
#line 76 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
              
                int i = 0;
                if (Model.ListAlbum != null)
                {


                    foreach (var item in Model.ListAlbum)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 4808, "\"", 4823, 2);
            WriteAttributeValue("", 4813, "myModal", 4813, 7, true);
#nullable restore
#line 84 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue(" ", 4820, i, 4821, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n                            <span class=\"close cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4895, "\"", 4934, 4);
            WriteAttributeValue("", 4905, "closeModal(\'myModal\'+\'", 4905, 22, true);
            WriteAttributeValue(" ", 4927, "\'+", 4928, 3, true);
#nullable restore
#line 85 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue(" ", 4930, i, 4931, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4933, ")", 4933, 1, true);
            EndWriteAttribute();
            WriteLiteral(">&times;</span>\r\n                            <div class=\"modal-content\">\r\n\r\n");
#nullable restore
#line 88 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                  
                                    for (int x = 0; x < item.MyProperty.Count(); x++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div");
            BeginWriteAttribute("class", " class=\"", 5217, "\"", 5236, 2);
            WriteAttributeValue("", 5225, "mySlides", 5225, 8, true);
#nullable restore
#line 91 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue(" ", 5233, i, 5234, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"numbertext\"> ");
#nullable restore
#line 92 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 92 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                     Write(item.MyProperty.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 5394, "\"", 5428, 1);
#nullable restore
#line 93 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 5400, item.MyProperty[x].Img_Path, 5400, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n                                        </div>\r\n");
#nullable restore
#line 95 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <!-- Next/previous controls -->
                                <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
                                <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>

                                <!-- Caption text -->
                                <div class=""caption-container"">
                                    <p id=""caption""></p>
                                </div>
                                <!-- Thumbnail image controls -->
                                <div class=""column"" style=""display:inline-block"">
                                    <img class=""demo"" src=""../Images/pic02.jpg"" onclick=""currentSlide(1)"" alt=""Nature""
                                         style=""width: 50%;height: 50%;"">
                                </div>

                            </div>
                        </div>
");
#nullable restore
#line 114 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                        i++;
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </section>
    <!----------------------------------------The Modal/Lightbox--------------------------------------------------->
    <section class=""ftco-section-2"" id=""OfferSEC"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:100px;"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <h2 class=""mb-4"">Offers</h2>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
            </div>
        </div>
        <div class=""row justify-content-center mb-5 pb-2"">
            <p>");
#nullable restore
#line 129 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
          Write(Model.Ph_Offers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </section>

    <section class=""ftco-section-2"" id=""ReviewSEC"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:100px;"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <h2 class=""mb-4"">Review</h2>
                <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country.</p>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec725fb16122bfedadf219a73341dada3a7afa5e21164", async() => {
                WriteLiteral(@"
            <div class=""form-group row justify-content-center"">
                <input type=""number"" min=""1"" max=""5"" id=""Quality""class=""form-control col-md-4"" placeholder=""Quality"" name=""Quality"">
            </div>
            <div class=""form-group row justify-content-center"">
                <input type=""number"" min=""1"" max=""5"" id=""TimeManagement"" class=""form-control col-md-4"" placeholder=""Time Commitment"" name=""TimeManagement"">
            </div>
            <div class=""form-group row justify-content-center"">
                <input type=""number"" min=""1"" max=""5"" id=""DeleverTime"" class=""form-control col-md-4"" placeholder=""Deliver Commitmnent"" name=""DeleverTime"">
            </div>
            <div class=""form-group row justify-content-center"">
                <textarea name=""ReviewMessage"" id=""ReviewMessage"" cols=""15"" rows=""4"" class=""form-control col-md-4"" placeholder=""Comment""></textarea>
            </div>
            <div class=""form-group row justify-content-center"">
                <inpu");
                WriteLiteral("t type=\"submit\" value=\"Post Your Review\" class=\"btn btn-primary py-3 px-5\" onclick=\"CreateComment()\">\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7785, "~/Home/PostReview/", 7785, 18, true);
#nullable restore
#line 140 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
AddHtmlAttributeValue("", 7803, Model.Ph_Id, 7803, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </section>

    <section class=""ftco-section-2"">
        <div class=""row justify-content-center mb-5 pb-2"" style=""margin-top:50px;"">
            <div class=""col-md-12"">
                <div class=""blog-comment"">
                    <h4>All Reviews</h4>
                    <hr />
                    <ul class=""comments"">
");
#nullable restore
#line 168 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                             foreach (var item in Model.Ph_Reviews)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"clearfix\">\r\n                                    <img src=\"https://bootdey.com/img/Content/user_1.jpg\" class=\"avatar\"");
            BeginWriteAttribute("alt", " alt=\"", 9637, "\"", 9643, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"post-comments\">\r\n                                        <p class=\"meta\">");
#nullable restore
#line 174 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                   Write(item.ReviewDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 174 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                        Write(item.ReviewDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 174 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                                               Write(item.ReviewDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"#\">");
#nullable restore
#line 174 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                                                                                 Write(item.ReviewedMember.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>   says : <i class=\"pull-right\" style=\"margin-right:100px\"><a href=\"#\"><small>sss</small></a></i></p>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 176 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                       Write(item.ReviewMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 180 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </section>



        <section class=""ftco-section contact-section"" id=""ContactSEC"">
            <div class=""container"">
                <div class=""row d-flex mb-5 contact-info"">
                    <div class=""col-md-12 mb-4"">
                        <h2 class=""h4 font-weight-bold"">Contact Information</h2>
                    </div>
                    <div class=""w-100""></div>
                    <div class=""col-md-3"">
                        <p><span>Address:</span>");
#nullable restore
#line 198 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                           Write(Model.Ph_Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <p><span>Phone:</span> <a href=\"#\">");
#nullable restore
#line 201 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                      Write(Model.Ph_PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <p><span>Email:</span> <a href=\"#\">");
#nullable restore
#line 204 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                      Write(Model.Ph_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                    </div>
                    <div class=""col-md-3"">
                        <p><span>Website</span> <a href=""#"">yoursite.com</a></p>
                    </div>
                </div>
                <div class=""row block-9"">
                    <div class=""col-md-6 order-md-last pr-md-5"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec725fb16122bfedadf219a73341dada3a7afa5e30150", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"Date\">Enter your date</label>\r\n                                <input type=\'text\' class=\"form-control\" id=\'txtDateAvailable\' name=\"Date\"");
                BeginWriteAttribute("onmousedown", " onmousedown=\"", 11858, "\"", 11896, 3);
                WriteAttributeValue("", 11872, "myFun(\'", 11872, 7, true);
#nullable restore
#line 215 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 11879, Model.TestDate, 11879, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11894, "\')", 11894, 2, true);
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                            <div class=""form-group"">
                                <textarea name=""Message"" id=""Message"" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Message""></textarea>
                            </div>
                            <div class=""form-group"">
                                <input type=""submit"" value=""Send Request"" class=""btn btn-primary py-3 px-5"">
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11560, "~/Home/PhoRequest/", 11560, 18, true);
#nullable restore
#line 212 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
AddHtmlAttributeValue("", 11578, Model.Ph_Id, 11578, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-6\">\r\n                        <div id=\"map\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <script>
        var availableDates;
        function myFun(list) {
            availableDates = list.split(',');
            $('#txtDateAvailable').datepicker({
                beforeShowDay:
                    function (dt) {
                        return [available(dt), """"];
                    }
                , changeMonth: true, changeYear: false
            });
        }

        function available(date) {
            dmy = date.getDate() + ""-0"" + (date.getMonth() + 1) + ""-"" + date.getFullYear();
            var li = dmy.split('-');
            if (li[0].length == 1) {
                dmy = `0${li[0]}-${li[1]}-${li[2]}`;
            }
            else {
                //11-05-2020
                dmy = date.getDate() + ""-0"" + (date.getMonth() + 1) + ""-"" + date.getFullYear();
            }
            if ($.inArray(dmy, availableDates) != -1) {
                return true;
            } else {
                return false;
            }
        }


    </script>");
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec725fb16122bfedadf219a73341dada3a7afa5e35301", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Photographer> Html { get; private set; }
    }
}
#pragma warning restore 1591
