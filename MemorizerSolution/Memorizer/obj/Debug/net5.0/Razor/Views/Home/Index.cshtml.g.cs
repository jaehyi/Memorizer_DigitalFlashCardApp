#pragma checksum "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39e1d8e88b88a903b66e16de4ad6e1fb447a3885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Views\_ViewImports.cshtml"
using Memorizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Views\_ViewImports.cshtml"
using Memorizer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Views\_ViewImports.cshtml"
using Memorizer.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e1d8e88b88a903b66e16de4ad6e1fb447a3885", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60dff5751857cd1a3c1e76b4460596a524a5e62e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    int? rightBoundary = User.Identity.Name?.IndexOf('@');
    string userName = rightBoundary != null ?
        User.Identity.Name.Substring(0, (int)rightBoundary) : null;
    string welcomeMessage = "Welcome to MemoRiser";
    welcomeMessage = userName != null ? welcomeMessage + $", {userName}!" : welcomeMessage + "!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39e1d8e88b88a903b66e16de4ad6e1fb447a38853990", async() => {
                WriteLiteral("\r\n    <div class=\"container text-center\">\r\n            <div class=\"display-3 text-primary pb-2\">\r\n                ");
#nullable restore
#line 13 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Views\Home\Index.cshtml"
           Write(welcomeMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        <div class=""row"">
            <img src=""/Images/TraditionalLibrary.jpg"" class=""img-fluid pb-2"" alt=""Alternate Text"" />
        </div>
        <div class=""display-4 mb-2 text-center"">Your Digital Flash Cards App</div>
        <div class=""h4"">Study using this app and watch your knowledge and confidence Rise!</div>
    </div>
");
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
