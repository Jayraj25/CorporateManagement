#pragma checksum "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286d1d868a703cc95d4c56401034a5206754469b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssignCandidate_Delete), @"mvc.1.0.view", @"/Views/AssignCandidate/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AssignCandidate/Delete.cshtml", typeof(AspNetCore.Views_AssignCandidate_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286d1d868a703cc95d4c56401034a5206754469b", @"/Views/AssignCandidate/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc68a41e10063d87b6e099c5bba6ac0b872f8a11", @"/Views/_ViewImports.cshtml")]
    public class Views_AssignCandidate_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<summer19.Model.Candidate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Candidate</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(257, 45, false);
#line 15 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(302, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(366, 41, false);
#line 18 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(407, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(470, 46, false);
#line 21 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(516, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(580, 42, false);
#line 24 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Middlename));

#line default
#line hidden
            EndContext();
            BeginContext(622, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(685, 44, false);
#line 27 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(729, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(793, 40, false);
#line 30 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(833, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(896, 44, false);
#line 33 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Jobtitle));

#line default
#line hidden
            EndContext();
            BeginContext(940, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1004, 40, false);
#line 36 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Jobtitle));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1107, 41, false);
#line 39 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1212, 37, false);
#line 42 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1312, 40, false);
#line 45 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cell));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1416, 36, false);
#line 48 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cell));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1515, 40, false);
#line 51 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Home));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1619, 36, false);
#line 54 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Home));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1718, 39, false);
#line 57 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1757, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1821, 35, false);
#line 60 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1919, 44, false);
#line 63 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2027, 40, false);
#line 66 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2130, 44, false);
#line 69 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(2174, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2238, 40, false);
#line 72 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(2278, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2341, 40, false);
#line 75 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2445, 36, false);
#line 78 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2544, 39, false);
#line 81 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2647, 35, false);
#line 84 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2682, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2745, 47, false);
#line 87 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Departement));

#line default
#line hidden
            EndContext();
            BeginContext(2792, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2856, 43, false);
#line 90 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Departement));

#line default
#line hidden
            EndContext();
            BeginContext(2899, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2962, 43, false);
#line 93 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(3005, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3069, 39, false);
#line 96 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(3108, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3171, 40, false);
#line 99 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hire));

#line default
#line hidden
            EndContext();
            BeginContext(3211, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3275, 36, false);
#line 102 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hire));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3374, 49, false);
#line 105 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Comptetenices));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3487, 45, false);
#line 108 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Comptetenices));

#line default
#line hidden
            EndContext();
            BeginContext(3532, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3595, 47, false);
#line 111 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Jobcategory));

#line default
#line hidden
            EndContext();
            BeginContext(3642, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3706, 43, false);
#line 114 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Jobcategory));

#line default
#line hidden
            EndContext();
            BeginContext(3749, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3812, 42, false);
#line 117 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(3854, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3918, 38, false);
#line 120 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Source));

#line default
#line hidden
            EndContext();
            BeginContext(3956, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4019, 48, false);
#line 123 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Resumeupload));

#line default
#line hidden
            EndContext();
            BeginContext(4067, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4131, 44, false);
#line 126 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Resumeupload));

#line default
#line hidden
            EndContext();
            BeginContext(4175, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4238, 43, false);
#line 129 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Resumes));

#line default
#line hidden
            EndContext();
            BeginContext(4281, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4345, 39, false);
#line 132 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Resumes));

#line default
#line hidden
            EndContext();
            BeginContext(4384, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4447, 42, false);
#line 135 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(4489, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4553, 38, false);
#line 138 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(4591, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4654, 44, false);
#line 141 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Feedback));

#line default
#line hidden
            EndContext();
            BeginContext(4698, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4762, 40, false);
#line 144 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Feedback));

#line default
#line hidden
            EndContext();
            BeginContext(4802, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4840, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "286d1d868a703cc95d4c56401034a5206754469b24250", async() => {
                BeginContext(4866, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4876, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "286d1d868a703cc95d4c56401034a5206754469b24643", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 149 "C:\Users\jayraj.thakur\Desktop\summerinternship\summer19\Views\AssignCandidate\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4912, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(4995, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "286d1d868a703cc95d4c56401034a5206754469b26563", async() => {
                    BeginContext(5017, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5033, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5046, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<summer19.Model.Candidate> Html { get; private set; }
    }
}
#pragma warning restore 1591
