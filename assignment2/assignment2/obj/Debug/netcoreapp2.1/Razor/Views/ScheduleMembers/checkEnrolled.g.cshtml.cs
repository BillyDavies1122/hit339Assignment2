#pragma checksum "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ddfd1068101ba2d5b92a8606dce7f746d2cb1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ScheduleMembers_checkEnrolled), @"mvc.1.0.view", @"/Views/ScheduleMembers/checkEnrolled.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ScheduleMembers/checkEnrolled.cshtml", typeof(AspNetCore.Views_ScheduleMembers_checkEnrolled))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ddfd1068101ba2d5b92a8606dce7f746d2cb1a", @"/Views/ScheduleMembers/checkEnrolled.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d14921b6e9a473ffe36cf77cfbdf8a2e29f453", @"/Views/_ViewImports.cshtml")]
    public class Views_ScheduleMembers_checkEnrolled : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<assignment2.Models.ScheduleMembers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e290e8a3be9949c7a026a77d5b39587c", async() => {
                BeginContext(151, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(165, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 46, false);
#line 16 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
           Write(Html.DisplayNameFor(model => model.ScheduleId));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 47, false);
#line 19 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
           Write(Html.DisplayNameFor(model => model.MemberEmail));

#line default
#line hidden
            EndContext();
            BeginContext(407, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 27 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
             if (ViewBag.session == item.ScheduleId) { 

#line default
#line hidden
            BeginContext(599, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(660, 45, false);
#line 30 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
               Write(Html.DisplayFor(modelItem => item.ScheduleId));

#line default
#line hidden
            EndContext();
            BeginContext(705, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(773, 46, false);
#line 33 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
               Write(Html.DisplayFor(modelItem => item.MemberEmail));

#line default
#line hidden
            EndContext();
            BeginContext(819, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
            }

#line default
#line hidden
#line 36 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\ScheduleMembers\checkEnrolled.cshtml"
             
        }

#line default
#line hidden
            BeginContext(889, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<assignment2.Models.ScheduleMembers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
