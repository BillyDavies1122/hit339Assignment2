#pragma checksum "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba106103474955e559302314da04c34000705a22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coaches_editMyProfile), @"mvc.1.0.view", @"/Views/Coaches/editMyProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Coaches/editMyProfile.cshtml", typeof(AspNetCore.Views_Coaches_editMyProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba106103474955e559302314da04c34000705a22", @"/Views/Coaches/editMyProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d14921b6e9a473ffe36cf77cfbdf8a2e29f453", @"/Views/_ViewImports.cshtml")]
    public class Views_Coaches_editMyProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<assignment2.Models.Coach>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(80, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd196ffd30c94faebc8ae92f938b3a2c", async() => {
                BeginContext(115, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(211, 1252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "820fe6372bef4f168cb6af5214cc6b0a", async() => {
                BeginContext(217, 88, true);
                WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(306, 38, false);
#line 20 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(344, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(400, 41, false);
#line 23 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(441, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(497, 45, false);
#line 26 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayNameFor(model => model.Biography));

#line default
#line hidden
                EndContext();
                BeginContext(542, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(598, 44, false);
#line 29 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayNameFor(model => model.PhotoUrl));

#line default
#line hidden
                EndContext();
                BeginContext(642, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 35 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
 foreach (var item in Model) {
        

#line default
#line hidden
#line 36 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
         if (ViewBag.userEmail == item.Email) { 

#line default
#line hidden
                BeginContext(810, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(859, 37, false);
#line 39 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(896, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(952, 40, false);
#line 42 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(992, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1048, 44, false);
#line 45 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayFor(modelItem => item.Biography));

#line default
#line hidden
                EndContext();
                BeginContext(1092, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1148, 43, false);
#line 48 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhotoUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1191, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1246, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efbe8474be744c1297e0d4ef57adc4c8", async() => {
                    BeginContext(1291, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
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
                BeginContext(1299, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1319, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89028afaf6ef4796a8e6d17c8b5f4a56", async() => {
                    BeginContext(1367, 7, true);
                    WriteLiteral("Details");
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
#line 52 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
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
                BeginContext(1378, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 55 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
        }

#line default
#line hidden
#line 55 "C:\Users\Billy\Documents\GitHub\hit339Assignment2\assignment2\assignment2\Views\Coaches\editMyProfile.cshtml"
         
    }

#line default
#line hidden
                BeginContext(1432, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1463, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<assignment2.Models.Coach>> Html { get; private set; }
    }
}
#pragma warning restore 1591
