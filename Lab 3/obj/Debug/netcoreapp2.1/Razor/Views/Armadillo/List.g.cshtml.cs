#pragma checksum "D:\CST465 Web Dev\Lab 3\Views\Armadillo\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4c6750d18f3a7544b2ccb42c7611a844444b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armadillo_List), @"mvc.1.0.view", @"/Views/Armadillo/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Armadillo/List.cshtml", typeof(AspNetCore.Views_Armadillo_List))]
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
#line 5 "D:\CST465 Web Dev\Lab 3\_ViewImports.cshtml"
using ArmadilloLib;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4c6750d18f3a7544b2ccb42c7611a844444b63", @"/Views/Armadillo/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c0367e026eaff823efb49ce7822de9c82c112f8", @"/_ViewImports.cshtml")]
    public class Views_Armadillo_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Armadillo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(73, 204, true);
            WriteLiteral("\r\n<table style=\"width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"text-align: left;\">Name</th>\r\n            <th style=\"text-align: left;\">Age</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 15 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\List.cshtml"
         foreach (var armadillo in Model)
        {

#line default
#line hidden
            BeginContext(331, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(370, 14, false);
#line 18 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\List.cshtml"
               Write(armadillo.Name);

#line default
#line hidden
            EndContext();
            BeginContext(384, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(412, 13, false);
#line 19 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\List.cshtml"
               Write(armadillo.Age);

#line default
#line hidden
            EndContext();
            BeginContext(425, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\List.cshtml"
        }

#line default
#line hidden
            BeginContext(462, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Armadillo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
