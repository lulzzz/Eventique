#pragma checksum "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1feef9bbe07fd3dbc2f1833a9d1134925eb93281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Des_Index), @"mvc.1.0.view", @"/Views/Des/Index.cshtml")]
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
#line 1 "E:\Final final project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Final final project\Eventique\Eventique\Views\_ViewImports.cshtml"
using Eventique.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1feef9bbe07fd3dbc2f1833a9d1134925eb93281", @"/Views/Des/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ce4e94c84015a294da61e99e735f0441e913c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Des_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Designer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Photographer.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Des", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddDesigner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateDesigner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveDesigner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1feef9bbe07fd3dbc2f1833a9d1134925eb932815767", async() => {
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
            WriteLiteral(@"

<input type=""button"" id=""btnShowModal"" value=""Add New Desiner"" class=""btn btn-primary"" />

<table class=""table"" id=""tableDesigner"">
    <thead style=""color:grey"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">PhoneNumber</th>
            <th scope=""col"">Address</th>
            <th scope=""col"">ShopName</th>
            <th scope=""col"">Email</th>

        </tr>
    </thead>
    <tbody style=""color:grey"">
");
#nullable restore
#line 23 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
           Write(item.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
           Write(item.Users.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                <a href=\"javascript:void(0);\" id=\"showeditDesignerModal\" class=\"edit\" data-toggle=\"modal\">\r\n                    Edit\r\n                </a>\r\n                <input type=\"hidden\" class=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1169, "\"", 1185, 1);
#nullable restore
#line 37 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
WriteAttributeValue("", 1177, item.ID, 1177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n            <td>\r\n                <a href=\"javascript:void(0);\" id=\"showdeleteDesignerModal\" class=\"delete\" data-toggle=\"modal\">\r\n                    Delete\r\n                </a>\r\n                <input type=\"hidden\" class=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1437, "\"", 1453, 1);
#nullable restore
#line 43 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
WriteAttributeValue("", 1445, item.ID, 1445, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "E:\Final final project\Eventique\Eventique\Views\Des\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"modal fade\" tabindex=\"-1\" id=\"ModalCreate\" data-keyboard=\"false\" data-backdrop=\"static\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feef9bbe07fd3dbc2f1833a9d1134925eb9328110751", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add Desiner</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        ×
                    </button>
                </div>
                <div class=""modal-body"">
");
                WriteLiteral(@"                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Name""
                               type=""text"" required=""required"" name=""Name"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""PhoneNumber""
                               type=""text"" required=""required"" name=""PhoneNumber"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Address""
                               type=""text"" required=""required"" name=""Address"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""ShopName""
                               type=""text"" required=""required"" name=""ShopName"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control");
                WriteLiteral(@""" placeholder=""Email""
                               type=""text"" required=""required"" name=""_Email"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" type=""text""  placeholder=""password"" name=""_password"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""submit"" class=""btn btn-success"" value=""Save"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade\" tabindex=\"-1\" id=\"ModalUpdate\" data-keyboard=\"false\" data-backdrop=\"static\">\r\n    <div class=\"modal-dialog modal-lg\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feef9bbe07fd3dbc2f1833a9d1134925eb9328114861", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Update Desiner</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        ×
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <input class=""form-control"" type=""text"" placeholder=""ID"" id=""IDDesigner"" required=""required"" name=""ID"" readonly />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Name""
                               type=""text"" id=""NameDesigner"" required=""required"" name=""Name"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""PhoneNumber""
                               type=""text"" id=""PhoneNumberDesigner"" required=""required"" name=""PhoneNumber"" />");
                WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""Address""
                               type=""text""  id=""AddressDesigner"" required=""required"" name=""Address"" />
                    </div>
                    <div class=""form-group"">
                        <input class=""form-control"" placeholder=""ShopName""
                               type=""text"" id=""ShopNameDesigner""  required=""required"" name=""ShopName"" />
                    </div>
                </div>
                <div class=""modal-footer"">
                    <input type=""submit"" class=""btn btn-success"" value=""Save"" />
                    <input type=""hidden"" name=""ID"" id=""id"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade\" id=\"ModalDelete\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1feef9bbe07fd3dbc2f1833a9d1134925eb9328118824", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Delete Designer</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                        ×
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Are you sure want to delete this records?</p>
                    <p class=""text-warning""><small>this Action cannot be undone</small></p>
                </div>
                <div class=""modal-footer"">
                    <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""cancel"" />
                    <input type=""submit"" class=""btn btn-danger"" value=""Delete"" />
                    <input type=""hidden"" id=""idhh"" name=""ID"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts2", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#btnShowModal"").click(function () {
                $(""#ModalCreate"").modal('show');
            });

            $("".delete"").click(function () {
                $(""#ModalDelete"").modal('show');
            });

            $("".edit"").click(function () {
                $(""#ModalUpdate"").modal('show');
            });

            $('table .delete').on('click', function () {
                var id = $(this).parent().find('.id').val();
                $(""#ModalDelete #idhh"").val(id);
            });

            $('table .edit').on('click', function () {
                var id = $(this).parent().find('.id').val();
                $.ajax({
                    type: 'GET',
                    url: '/Des/FindDesigner/' + id,
                    success: function (Des) {
                        $('#ModalUpdate #IDDesigner').val(Des.ID);
                        $('#ModalUpdate #NameDesigner').val(");
                WriteLiteral(@"Des.Name);
                        $('#ModalUpdate #PhoneNumberDesigner').val(Des.PhoneNumber);
                        $('#ModalUpdate #AddressDesigner').val(Des.Address);
                        $('#ModalUpdate #ShopNameDesigner').val(Des.ShopName);
                        
                    }
                });
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Designer>> Html { get; private set; }
    }
}
#pragma warning restore 1591