#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a04f694337d953a8925340e53f44b97efb2127a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Show.cshtml", typeof(AspNetCore.Views_Orders_Show))]
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
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
using VenderTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a04f694337d953a8925340e53f44b97efb2127a", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(56, 6, true);
            WriteLiteral("  <h2>");
            EndContext();
            BeginContext(63, 11, false);
#line 6 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(74, 31, true);
            WriteLiteral("</h2>\n  <h4><span>Type:</span> ");
            EndContext();
            BeginContext(106, 10, false);
#line 7 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
                    Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(116, 33, true);
            WriteLiteral("</h4>\n  <h4><span>Amount:</span> ");
            EndContext();
            BeginContext(150, 12, false);
#line 8 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
                      Write(Model.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(162, 32, true);
            WriteLiteral("</h4>\n  <h4><span>Price:</span> ");
            EndContext();
            BeginContext(195, 11, false);
#line 9 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
                     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(206, 35, true);
            WriteLiteral("</h4>\n  <h4><span>Due Date:</span> ");
            EndContext();
            BeginContext(242, 10, false);
#line 10 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Orders/Show.cshtml"
                        Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(252, 5, true);
            WriteLiteral("</h4>");
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