#pragma checksum "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Home\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8085732b39080718a8837a6f4e4a43a0accbc98e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Gallery), @"mvc.1.0.view", @"/Views/Home/Gallery.cshtml")]
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
#line 1 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\_ViewImports.cshtml"
using DentistApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\_ViewImports.cshtml"
using DentistApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8085732b39080718a8837a6f4e4a43a0accbc98e", @"/Views/Home/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4f3db2c88cf472073554de437c3c2e0520ba96", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Home\Gallery.cshtml"
  
    ViewData["Title"] = "Gallery";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""gallerybg"">
        <h1 class=""text-center font-serif text-3xl md:text-4xl pb-4 text-white"">Gallery</h1>
    </div>
    <div class=""container mx-auto max-w-4xl py-20 px-8"">
        <div class=""grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-5"">
            <img src=""/imgs/caroline-lm-8BkF0sTC6Uo-unsplash.jpg"" class=""w-full""");
            BeginWriteAttribute("alt", " alt=\"", 394, "\"", 400, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img src=\"/imgs/four.jpg\" class=\"w-full\"");
            BeginWriteAttribute("alt", " alt=\"", 456, "\"", 462, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img src=\"/imgs/rudi-fargo-MjO2ZWzPLtc-unsplash.jpg\" class=\"w-full\"");
            BeginWriteAttribute("alt", " alt=\"", 545, "\"", 551, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img src=\"/imgs/two.png\" class=\"w-full\"");
            BeginWriteAttribute("alt", " alt=\"", 606, "\"", 612, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img src=\"/imgs/one.jpg\" class=\"w-full\"");
            BeginWriteAttribute("alt", " alt=\"", 667, "\"", 673, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img src=\"/imgs/three.jpg\" class=\"w-full\"");
            BeginWriteAttribute("alt", " alt=\"", 730, "\"", 736, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
