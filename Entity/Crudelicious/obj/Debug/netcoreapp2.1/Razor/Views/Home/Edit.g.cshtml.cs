#pragma checksum "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0296356abb89a8bb2ca35698afb33782e084f19e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
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
#line 1 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/_ViewImports.cshtml"
using Crudelicious;

#line default
#line hidden
#line 2 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/_ViewImports.cshtml"
using Crudelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0296356abb89a8bb2ca35698afb33782e084f19e", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crudelicious.Models.Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml"
  
    ViewData["Title"] = "Edit Dish Page";

#line default
#line hidden
            BeginContext(83, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(120, 437, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d10c58b23d46068b297e60419334d3", async() => {
                BeginContext(126, 424, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv='X-UA-compatible' content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO""
        crossorigin=""anonymous"">
    <title>CRUDelicious</title>
");
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
            BeginContext(557, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(561, 1035, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d9329c7daf84433a8819b535126ff0b", async() => {
                BeginContext(567, 97, true);
                WriteLiteral("\r\n    <div id=\"container\">\r\n        <h5>Edit a Dish!</h5>\r\n        <a href=\"/\">Home</a>\r\n        ");
                EndContext();
                BeginContext(664, 895, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "904d775b364f4638b870eb45b103f8b7", async() => {
                    BeginContext(704, 179, true);
                    WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-sm\">\r\n                <table cellpadding=\"10px\">\r\n                <tr>\r\n                    <p>Dish Name<input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 883, "\"", 914, 1);
#line 26 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml"
WriteAttributeValue("", 891, ViewBag.ShownDish.Name, 891, 23, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(915, 69, true);
                    WriteLiteral(" name=\"Name\"></p>\r\n                    <p>Dish Chef<input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 984, "\"", 1015, 1);
#line 27 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml"
WriteAttributeValue("", 992, ViewBag.ShownDish.Chef, 992, 23, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1016, 76, true);
                    WriteLiteral(" name=\"Chef\"></p>\r\n                    <p>Dish Description<input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1092, "\"", 1130, 1);
#line 28 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml"
WriteAttributeValue("", 1100, ViewBag.ShownDish.Description, 1100, 30, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1131, 81, true);
                    WriteLiteral(" name=\"Description\"></p>\r\n                    <p>Dish Tastiness<input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1212, "\"", 1248, 1);
#line 29 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml"
WriteAttributeValue("", 1220, ViewBag.ShownDish.Tastiness, 1220, 28, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1249, 78, true);
                    WriteLiteral(" name=\"Tastiness\"></p>\r\n                    <p>Dish Calories<input type=\"text\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1327, "\"", 1362, 1);
#line 30 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/Entity/Crudelicious/Views/Home/Edit.cshtml"
WriteAttributeValue("", 1335, ViewBag.ShownDish.Calories, 1335, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1363, 189, true);
                    WriteLiteral(" name=\"Calories\"></p>\r\n                </tr>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-sm\">\r\n            </div>\r\n            <input type=\"submit\">\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1559, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(1596, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crudelicious.Models.Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591