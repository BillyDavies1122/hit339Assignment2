#pragma checksum "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b5f58216e34f3acbc76893f1be7cbbbeabe461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedules_mySchedules), @"mvc.1.0.view", @"/Views/Schedules/mySchedules.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schedules/mySchedules.cshtml", typeof(AspNetCore.Views_Schedules_mySchedules))]
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
#line 1 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\_ViewImports.cshtml"
using assignment2;

#line default
#line hidden
#line 2 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\_ViewImports.cshtml"
using assignment2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b5f58216e34f3acbc76893f1be7cbbbeabe461", @"/Views/Schedules/mySchedules.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d14921b6e9a473ffe36cf77cfbdf8a2e29f453", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedules_mySchedules : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<assignment2.Models.Schedule>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ScheduleMembers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkEnrolled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 14, false);
#line 2 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
Write(ViewBag.userId);

#line default
#line hidden
            EndContext();
            BeginContext(64, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(109, 21, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n<p>");
            EndContext();
            BeginContext(131, 17, false);
#line 9 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
Write(ViewBag.userEmail);

#line default
#line hidden
            EndContext();
            BeginContext(148, 15, true);
            WriteLiteral("</p>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(163, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edbfe553893b40e28ef6b7ec51dcbd37", async() => {
                BeginContext(186, 27, true);
                WriteLiteral("Create New Coaching Session");
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
            BeginContext(217, 106, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(324, 40, false);
#line 18 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
           Write(Html.DisplayNameFor(model => model.When));

#line default
#line hidden
            EndContext();
            BeginContext(364, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(420, 47, false);
#line 21 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(523, 44, false);
#line 24 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(567, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
 foreach (var item in Model) {
    

#line default
#line hidden
#line 31 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
     if (ViewBag.userEmail == item.CoachEmail){

#line default
#line hidden
            BeginContext(734, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(783, 39, false);
#line 34 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
           Write(Html.DisplayFor(modelItem => item.When));

#line default
#line hidden
            EndContext();
            BeginContext(822, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(878, 46, false);
#line 37 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(924, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(980, 43, false);
#line 40 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 37, true);
            WriteLiteral("\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(1060, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f1ef7a13914c5582bd226a3208e527", async() => {
                BeginContext(1147, 15, true);
                WriteLiteral("Who is enrolled");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
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
            BeginContext(1166, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
    }

#line default
#line hidden
#line 44 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Schedules\mySchedules.cshtml"
     
        
}

#line default
#line hidden
            BeginContext(1208, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<assignment2.Models.Schedule>> Html { get; private set; }
    }
}
#pragma warning restore 1591
