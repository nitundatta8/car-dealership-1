#pragma checksum "/Users/juliaseidman/Documents/Epicodus/Week_10/Dealership.Solution/Views/Cars/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be36bc5d72c849ad6c8e2f1e3d75bb3d15b19ff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
#line 1 "/Users/juliaseidman/Documents/Epicodus/Week_10/Dealership.Solution/Views/Cars/Index.cshtml"
using Dealership.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be36bc5d72c849ad6c8e2f1e3d75bb3d15b19ff0", @"/Views/Cars/Index.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 42, true);
            WriteLiteral("\n<h1>Cars For Sale At NJ Junky!</h1>\n<ul>\n");
            EndContext();
#line 5 "/Users/juliaseidman/Documents/Epicodus/Week_10/Dealership.Solution/Views/Cars/Index.cshtml"
   foreach (Car car in Model)
  {

#line default
#line hidden
            BeginContext(102, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(111, 13, false);
#line 7 "/Users/juliaseidman/Documents/Epicodus/Week_10/Dealership.Solution/Views/Cars/Index.cshtml"
   Write(car.MakeModel);

#line default
#line hidden
            EndContext();
            BeginContext(124, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 8 "/Users/juliaseidman/Documents/Epicodus/Week_10/Dealership.Solution/Views/Cars/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(134, 7, true);
            WriteLiteral("\n</ul>\n");
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
