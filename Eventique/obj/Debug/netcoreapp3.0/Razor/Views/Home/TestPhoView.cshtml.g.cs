#pragma checksum "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a080fadb7e786b564833de1ebd3275f4fd7b6ab"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a080fadb7e786b564833de1ebd3275f4fd7b6ab", @"/Views/Home/TestPhoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestPhoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Photographer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jqueryui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
    <div id=""colorlib-main"">
        <div class=""hero-wrap js-fullheight"" id=""AboutSEC"" style=""background-image: url(/Images/bg_1.jpg);"" data-stellar-background-ratio=""0.5"">
            <div class=""overlay""></div>
            <div class=""js-fullheight d-flex justify-content-center align-items-center"">
                <div class=""col-md-8 text text-center"">
                    <div class=""img mb-4""");
            BeginWriteAttribute("style", " style=\"", 552, "\"", 600, 4);
            WriteAttributeValue("", 560, "background-image:", 560, 17, true);
            WriteAttributeValue(" ", 577, "url(", 578, 5, true);
#nullable restore
#line 15 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 582, Model.ImagePath, 582, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 598, ");", 598, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    <div class=\"desc\">\r\n                        <h2 class=\"subheading\">Hello I\'m</h2>\r\n                        <h1 class=\"mb-4\">");
#nullable restore
#line 18 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
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
                <di");
            WriteLiteral("v class=\"row\">\r\n");
#nullable restore
#line 35 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                         if (Model.ListAlbum != null)
                        {
                            int j = 0;
                            foreach (var item in Model.ListAlbum)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-4\">\r\n                                    <div class=\"blog-entry ftco-animate\">\r\n                                        <div src=\"#\" class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 2247, "\"", 2307, 4);
            WriteAttributeValue("", 2255, "background-image:", 2255, 17, true);
            WriteAttributeValue(" ", 2272, "url(", 2273, 5, true);
#nullable restore
#line 42 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 2277, item.MyProperty[j].Img_Path, 2277, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2305, ");", 2305, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2308, "\"", 2381, 8);
            WriteAttributeValue("", 2318, "openModal(\'myModal\'+\'", 2318, 21, true);
            WriteAttributeValue(" ", 2339, "\'+", 2340, 3, true);
#nullable restore
#line 42 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 2342, j, 2342, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2344, ",", 2345, 2, true);
            WriteAttributeValue(" ", 2346, "\'mySlides\'+\'", 2347, 13, true);
            WriteAttributeValue(" ", 2359, "\'+", 2360, 3, true);
#nullable restore
#line 42 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 2362, j, 2362, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2364, ");currentSlide(1)", 2364, 17, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                        <div class=""text text-2 pt-2 mt-3"">
                                            <span class=""category mb-3 d-block""><a href=""#"">Technology</a></span>
                                            <h3 class=""mb-4""><a href=""#"">");
#nullable restore
#line 45 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
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
                     ");
            WriteLiteral(@"                                   <span><i class=""icon-heart""></i>3</span>
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
#line 69 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                j++;
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!------------------------ The Modal/Lightbox ------------------------------>\r\n");
#nullable restore
#line 75 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                  
                    int i = 0;
                    if (Model.ListAlbum != null)
                    {


                        foreach (var item in Model.ListAlbum)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("id", " id=\"", 5034, "\"", 5049, 2);
            WriteAttributeValue("", 5039, "myModal", 5039, 7, true);
#nullable restore
#line 83 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue(" ", 5046, i, 5047, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n                                <span class=\"close cursor\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5125, "\"", 5164, 4);
            WriteAttributeValue("", 5135, "closeModal(\'myModal\'+\'", 5135, 22, true);
            WriteAttributeValue(" ", 5157, "\'+", 5158, 3, true);
#nullable restore
#line 84 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue(" ", 5160, i, 5161, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5163, ")", 5163, 1, true);
            EndWriteAttribute();
            WriteLiteral(">&times;</span>\r\n                                <div class=\"modal-content\">\r\n\r\n");
#nullable restore
#line 87 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                      
                                        for (int x = 0; x < item.MyProperty.Count(); x++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div");
            BeginWriteAttribute("class", " class=\"", 5467, "\"", 5486, 2);
            WriteAttributeValue("", 5475, "mySlides", 5475, 8, true);
#nullable restore
#line 90 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue(" ", 5483, i, 5484, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"numbertext\"> ");
#nullable restore
#line 91 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                    Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 91 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                                         Write(item.MyProperty.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 5652, "\"", 5686, 1);
#nullable restore
#line 92 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 5658, item.MyProperty[x].Img_Path, 5658, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n                                            </div>\r\n");
#nullable restore
#line 94 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
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
#line 113 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                            i++;
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
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
#line 128 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a080fadb7e786b564833de1ebd3275f4fd7b6ab19811", async() => {
                WriteLiteral(@"
                <div class=""form-group row justify-content-center"">
                    <input type=""number"" min=""1"" max=""5"" class=""form-control col-md-4"" placeholder=""Quality"" name=""Quality"">
                </div>
                <div class=""form-group row justify-content-center"">
                    <input type=""number"" min=""1"" max=""5"" class=""form-control col-md-4"" placeholder=""Time Commitment"" name=""TimeManagement"">
                </div>
                <div class=""form-group row justify-content-center"">
                    <input type=""number"" min=""1"" max=""5"" class=""form-control col-md-4"" placeholder=""Deliver Commitmnent"" name=""DeleverTime"">
                </div>
                <div class=""form-group row justify-content-center"">
                    <textarea name=""ReviewMessage""");
                BeginWriteAttribute("id", " id=\"", 9086, "\"", 9091, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""15"" rows=""4"" class=""form-control col-md-4"" placeholder=""Comment""></textarea>
                </div>
                <div class=""form-group row justify-content-center"">
                    <input type=""submit"" value=""Post Your Review"" class=""btn btn-primary py-3 px-5"">
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8215, "~/Home/PostReview/", 8215, 18, true);
#nullable restore
#line 139 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
AddHtmlAttributeValue("", 8233, Model.Ph_Id, 8233, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </section>
        <input type=""button"" id=""btnShowModal"" value=""See All Reviews"" class=""btn btn-primary"" />

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
#line 167 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                           Write(Model.Ph_Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <p><span>Phone:</span> <a href=\"#\">");
#nullable restore
#line 170 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
                                                      Write(Model.Ph_PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <p><span>Email:</span> <a href=\"#\">");
#nullable restore
#line 173 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a080fadb7e786b564833de1ebd3275f4fd7b6ab25624", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"Date\">Enter your date</label>\r\n                                <input type=\'text\' class=\"form-control\" id=\'txtDateAvailable\' name=\"Date\"");
                BeginWriteAttribute("onmousedown", " onmousedown=\"", 11011, "\"", 11049, 3);
                WriteAttributeValue("", 11025, "myFun(\'", 11025, 7, true);
#nullable restore
#line 184 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
WriteAttributeValue("", 11032, Model.TestDate, 11032, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 11047, "\')", 11047, 2, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10713, "~/Home/PhoRequest/", 10713, 18, true);
#nullable restore
#line 181 "D:\Courses\ITI\projects\Graduation Project\Eventique\Eventique\Views\Home\TestPhoView.cshtml"
AddHtmlAttributeValue("", 10731, Model.Ph_Id, 10731, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-6\">\r\n                        <div id=\"map\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
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
     
            
    </script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a080fadb7e786b564833de1ebd3275f4fd7b6ab30694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
