#pragma checksum "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/ASP MVC II/RandomPasscode/Views/Home/Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef0e82026f08dd57eaf00694c8f5a9051b9e346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index2.cshtml", typeof(AspNetCore.Views_Home_Index2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef0e82026f08dd57eaf00694c8f5a9051b9e346", @"/Views/Home/Index2.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 171, true);
            WriteLiteral("<!-- <!DOCTYPE html>\n<html>\n    <head>\n        <title>Random Passcode</title>\n        <meta charset=\"utf-8\">\n    </head>\n    <body>\n        <h2>Random Passcode (passcode #");
            EndContext();
            BeginContext(172, 13, false);
#line 8 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/ASP MVC II/RandomPasscode/Views/Home/Index2.cshtml"
                                  Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(185, 19, true);
            WriteLiteral(")</h2>\n        <h1>");
            EndContext();
            BeginContext(205, 14, false);
#line 9 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/ASP MVC II/RandomPasscode/Views/Home/Index2.cshtml"
       Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(219, 132, true);
            WriteLiteral("</h1>\n        <form action=\"generate\" method=\"post\">\n            <input type=\"submit\">\n        </form>\n    </body>\n</html> -->\n\n<h1>");
            EndContext();
            BeginContext(352, 12, false);
#line 16 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/ASP MVC II/RandomPasscode/Views/Home/Index2.cshtml"
Write(ViewBag.Pass);

#line default
#line hidden
            EndContext();
            BeginContext(364, 10, true);
            WriteLiteral("</h1>\n<h1>");
            EndContext();
            BeginContext(375, 13, false);
#line 17 "/Users/boldgoldman/Documents/Developer Files/Coding Dojo/C#/ASP MVC II/RandomPasscode/Views/Home/Index2.cshtml"
Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(388, 5, true);
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
