#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d140595d189f688dd0c9ed0e801837f73179482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venders_Index), @"mvc.1.0.view", @"/Views/Venders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venders/Index.cshtml", typeof(AspNetCore.Views_Venders_Index))]
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
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/Index.cshtml"
using VenderTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d140595d189f688dd0c9ed0e801837f73179482", @"/Views/Venders/Index.cshtml")]
    public class Views_Venders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(55, 32, true);
            WriteLiteral("  <h1>Venders Index</h1>\n  <ul>\n");
            EndContext();
#line 7 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/Index.cshtml"
     foreach (Vender vender in Model)
    {

#line default
#line hidden
            BeginContext(131, 21, true);
            WriteLiteral("      <a href=\"\"><li>");
            EndContext();
            BeginContext(153, 11, false);
#line 9 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/Index.cshtml"
                Write(vender.Name);

#line default
#line hidden
            EndContext();
            BeginContext(164, 10, true);
            WriteLiteral("</li></a>\n");
            EndContext();
#line 10 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(180, 52, true);
            WriteLiteral("  </ul>\n  <a href=\"/venders/new\">Add New Vender</a>\n");
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
