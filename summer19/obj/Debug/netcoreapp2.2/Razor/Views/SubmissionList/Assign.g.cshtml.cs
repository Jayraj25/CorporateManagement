#pragma checksum "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e51c460980e7dc3bf2c31cf5652dcaf45f934a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SubmissionList_Assign), @"mvc.1.0.view", @"/Views/SubmissionList/Assign.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SubmissionList/Assign.cshtml", typeof(AspNetCore.Views_SubmissionList_Assign))]
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
#line 1 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\_ViewImports.cshtml"
using summer19;

#line default
#line hidden
#line 2 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\_ViewImports.cshtml"
using summer19.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e51c460980e7dc3bf2c31cf5652dcaf45f934a9", @"/Views/SubmissionList/Assign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc68a41e10063d87b6e099c5bba6ac0b872f8a11", @"/Views/_ViewImports.cshtml")]
    public class Views_SubmissionList_Assign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<summer19.Model.Candidate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icon/pdf.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Resume"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Assign"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
  
    ViewData["Title"] = "Assign";

#line default
#line hidden
            BeginContext(90, 220, true);
            WriteLiteral("\r\n<h3>Assign</h3>\r\n\r\n<table class=\"table table-bordered table-hover\" cellspacing=\"0\" width=\"100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(311, 44, false);
#line 16 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
           Write(Html.DisplayNameFor(model => model.Jobtitle));

#line default
#line hidden
            EndContext();
            BeginContext(355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 41, false);
#line 19 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(452, 120, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Department\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(573, 40, false);
#line 25 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
           Write(Html.DisplayNameFor(model => model.Hire));

#line default
#line hidden
            EndContext();
            BeginContext(613, 84, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Status</th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(698, 47, false);
#line 29 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
           Write(Html.DisplayNameFor(model => model.Jobcategory));

#line default
#line hidden
            EndContext();
            BeginContext(745, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(801, 42, false);
#line 32 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
           Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(843, 117, true);
            WriteLiteral("\r\n            </th>\r\n            <th> Resumes</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1009, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1070, 44, false);
#line 43 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1137, 43, false);
#line 44 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1248, 43, false);
#line 47 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Jobtitle));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1359, 40, false);
#line 50 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1467, 46, false);
#line 53 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Departement));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1581, 39, false);
#line 56 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hire));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1688, 41, false);
#line 59 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1797, 46, false);
#line 62 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Jobcategory));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1911, 41, false);
#line 65 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
               Write(Html.DisplayFor(modelItem => item.Source));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2019, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e51c460980e7dc3bf2c31cf5652dcaf45f934a913149", async() => {
                BeginContext(2104, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2130, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e51c460980e7dc3bf2c31cf5652dcaf45f934a913555", async() => {
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
                EndContext();
                BeginContext(2178, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2028, "~/Files/", 2028, 8, true);
#line 68 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
AddHtmlAttributeValue("", 2036, item.Resumes, 2036, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2204, 69, true);
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2273, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e51c460980e7dc3bf2c31cf5652dcaf45f934a916565", async() => {
                BeginContext(2309, 62, true);
                WriteLiteral("<input type=\"submit\" class=\"btn btn-primary\" value=\"Assign\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2378, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 77 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\SubmissionList\Assign.cshtml"
        }

#line default
#line hidden
            BeginContext(2433, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<summer19.Model.Candidate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
