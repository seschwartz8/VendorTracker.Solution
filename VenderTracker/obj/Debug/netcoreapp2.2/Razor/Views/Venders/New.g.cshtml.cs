#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a2e8856e08bd402ce78ef727b62bc9eb821692"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venders_New), @"mvc.1.0.view", @"/Views/Venders/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venders/New.cshtml", typeof(AspNetCore.Views_Venders_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a2e8856e08bd402ce78ef727b62bc9eb821692", @"/Views/Venders/New.cshtml")]
    public class Views_Venders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/VenderTracker.Solution/VenderTracker/Views/Venders/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 505, true);
            WriteLiteral(@"  <h1>Create New Vender</h1>
  <form action=""/"" method=""post"">
    <div class=""form-group"">
      <label for=""name"">Vender Name</label>
      <input id=""name"" name=""name"" type=""text"" required>
    </div>
    <div class=""form-group"">
      <label for=""description"">Vender Description</label>
      <input id=""description"" name=""description"" type=""text"" required>
    </div>
    <button class=""btn"" type=""submit"">Create</button>
  </form>

<div class=""links"">
  <a href=""/venders"">Back To Venders</a>
</div>");
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
