#pragma checksum "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75b43cb07dfbea5d908be4041de3e9aed3b6211b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Index), @"mvc.1.0.view", @"/Views/Candidates/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Candidates/Index.cshtml", typeof(AspNetCore.Views_Candidates_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b43cb07dfbea5d908be4041de3e9aed3b6211b", @"/Views/Candidates/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc68a41e10063d87b6e099c5bba6ac0b872f8a11", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<summer19.Model.Candidate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 78, true);
            WriteLiteral("\r\n<h3 style=\"margin-top:10px;margin-bottom:10px;\">\r\n    Candidate Search\r\n    ");
            EndContext();
            BeginContext(167, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b43cb07dfbea5d908be4041de3e9aed3b6211b4799", async() => {
                BeginContext(190, 130, true);
                WriteLiteral("<button class=\"btn btn-primary\" style=\"float:right;\"><i class=\"fa fa-plus\" style=\"margin:5px;\" aria-hidden=\"true\"></i>Add</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(324, 152, true);
            WriteLiteral("\r\n</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Name\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 44, false);
#line 18 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Jobtitle));

#line default
#line hidden
            EndContext();
            BeginContext(521, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(577, 41, false);
#line 21 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(618, 120, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Department\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(739, 40, false);
#line 27 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hire));

#line default
#line hidden
            EndContext();
            BeginContext(779, 84, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Status</th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(864, 47, false);
#line 31 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Jobcategory));

#line default
#line hidden
            EndContext();
            BeginContext(911, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(967, 42, false);
#line 34 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 117, true);
            WriteLiteral("\r\n            </th>\r\n            <th> Resumes</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1175, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1224, 44, false);
#line 45 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1287, 45, false);
#line 46 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1351, 43, false);
#line 47 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1450, 43, false);
#line 50 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Jobtitle));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1549, 40, false);
#line 53 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1645, 46, false);
#line 56 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Departement));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1747, 39, false);
#line 59 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hire));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1842, 48, false);
#line 62 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comptetenices));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1946, 46, false);
#line 65 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Jobcategory));

#line default
#line hidden
            EndContext();
            BeginContext(1992, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2048, 41, false);
#line 68 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Source));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2145, 47, false);
#line 71 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Resumeupload));

#line default
#line hidden
            EndContext();
            BeginContext(2192, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2248, 42, false);
#line 74 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Resumes));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2346, 41, false);
#line 77 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2442, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b43cb07dfbea5d908be4041de3e9aed3b6211b14581", async() => {
                BeginContext(2487, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2495, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2515, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b43cb07dfbea5d908be4041de3e9aed3b6211b16934", async() => {
                BeginContext(2563, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2574, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2594, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75b43cb07dfbea5d908be4041de3e9aed3b6211b19293", async() => {
                BeginContext(2641, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2651, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 85 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\Candidates\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2698, 24, true);
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
