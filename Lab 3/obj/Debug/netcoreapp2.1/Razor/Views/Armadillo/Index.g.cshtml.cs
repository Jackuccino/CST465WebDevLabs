#pragma checksum "D:\CST465 Web Dev\Lab 3\Views\Armadillo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593d2cfc85d4ece9d914f44b0c7a848015c0513b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armadillo_Index), @"mvc.1.0.view", @"/Views/Armadillo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Armadillo/Index.cshtml", typeof(AspNetCore.Views_Armadillo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593d2cfc85d4ece9d914f44b0c7a848015c0513b", @"/Views/Armadillo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c0367e026eaff823efb49ce7822de9c82c112f8", @"/_ViewImports.cshtml")]
    public class Views_Armadillo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Armadillo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\Index.cshtml"
 using (Html.BeginForm("Search", "Armadillo", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(131, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(170, 59, false);
#line 10 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\Index.cshtml"
   Write(Html.LabelFor(m => m.Name, new { @class ="control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(229, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(240, 61, false);
#line 11 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\Index.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(301, 71, true);
            WriteLiteral("\r\n    </div>\r\n        <button type=\"submit\">Search Armadillo</button>\r\n");
            EndContext();
#line 14 "D:\CST465 Web Dev\Lab 3\Views\Armadillo\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Armadillo> Html { get; private set; }
    }
}
#pragma warning restore 1591
