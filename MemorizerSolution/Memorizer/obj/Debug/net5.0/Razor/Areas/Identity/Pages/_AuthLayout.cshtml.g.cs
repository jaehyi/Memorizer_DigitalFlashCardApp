#pragma checksum "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acc8357ac4381398107a08b7fe274cc6f7a22f6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_ViewImports.cshtml"
using Memorizer.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_ViewImports.cshtml"
using Memorizer.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_ViewImports.cshtml"
using Memorizer.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acc8357ac4381398107a08b7fe274cc6f7a22f6c", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c3c75a82252cb00a6727ed43665fe755222af0", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""pb-3"">Welcome to MemoRiser!</h1>
    <h4 class=""pb-4"">To continue, please sign in below</h4>
</div>

<div class=""container"">
    <div class=""card"">
        <div class=""card-header"">
            <ul class=""nav nav-tabs card-header-tabs"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Identity/Account/Login"">Sign In</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/Identity/Account/Register"">Sign Up</a>
                </li>
            </ul>
        </div>
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-12"">
                    ");
#nullable restore
#line 25 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_AuthLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 33 "C:\Users\Jae Yi\Desktop\GitHub Repo\Memorizer_DigitalFlashCardApp\MemorizerSolution\Memorizer\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<script>
    $(function () {
        var current = location.pathname;
        $('.nav-tabs li a').each(function () {
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
    })
</script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
