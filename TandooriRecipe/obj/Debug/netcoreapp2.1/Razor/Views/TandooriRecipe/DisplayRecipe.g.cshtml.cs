#pragma checksum "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f4ca00f609d8028d5364f598403e9a738980989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TandooriRecipe_DisplayRecipe), @"mvc.1.0.view", @"/Views/TandooriRecipe/DisplayRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TandooriRecipe/DisplayRecipe.cshtml", typeof(AspNetCore.Views_TandooriRecipe_DisplayRecipe))]
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
#line 1 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\_ViewImports.cshtml"
using TandooriRecipe;

#line default
#line hidden
#line 2 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\_ViewImports.cshtml"
using TandooriRecipe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f4ca00f609d8028d5364f598403e9a738980989", @"/Views/TandooriRecipe/DisplayRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4668e9e90bec853b02f0d7cd613000bc7bf7cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_TandooriRecipe_DisplayRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TandooriRecipe.Models.RecipeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(102, 175, true);
            WriteLiteral("    <div class=\"card back\">\r\n         <div class=\"yellow\"></div>\r\n         <div class=\"top dots\"></div>\r\n        <div class=\"personal-info\">\r\n            <p class=\"display-2\">");
            EndContext();
            BeginContext(278, 10, false);
#line 13 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(288, 39, true);
            WriteLiteral("</p>\r\n            <p class=\"display-3\">");
            EndContext();
            BeginContext(328, 12, false);
#line 14 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
                            Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(340, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(342, 18, false);
#line 14 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
                                          Write(Model.TimeRequired);

#line default
#line hidden
            EndContext();
            BeginContext(360, 34, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">");
            EndContext();
            BeginContext(395, 17, false);
#line 15 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
                       Write(Model.Ingredients);

#line default
#line hidden
            EndContext();
            BeginContext(412, 34, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">");
            EndContext();
            BeginContext(447, 16, false);
#line 16 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
                       Write(Model.Directions);

#line default
#line hidden
            EndContext();
            BeginContext(463, 109, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"bottom dots\"></div>\r\n        <div class=\"pink\"></div>\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\300985889\source\WebAssignmentWorking\TandooriRecipe\Views\TandooriRecipe\DisplayRecipe.cshtml"
}

#line default
#line hidden
            BeginContext(575, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TandooriRecipe.Models.RecipeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
