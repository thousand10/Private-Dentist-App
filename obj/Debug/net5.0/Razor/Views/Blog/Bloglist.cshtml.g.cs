#pragma checksum "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865707ecd7e5d3b7bd350eec7acaade33abc0414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Bloglist), @"mvc.1.0.view", @"/Views/Blog/Bloglist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865707ecd7e5d3b7bd350eec7acaade33abc0414", @"/Views/Blog/Bloglist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4f3db2c88cf472073554de437c3c2e0520ba96", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Bloglist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DentistApp.Models.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-black py-2 px-10 text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
  
    ViewData["Title"] = "Blogs-Lists";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""aboutbg px-8"">
        <h1 class=""text-center font-serif text-3xl md:text-4xl pb-4 text-white"">Blog's</h1>
    </div>
    <div class=""container mx-auto max-w-4xl py-20 px-8"">
        <h1 class=""font-serif text-3xl md:text-4xl pb-4  pb-10"">Blog Posts</h1>

");
#nullable restore
#line 14 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
         if(Model.Count() >= 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-5\">\r\n");
#nullable restore
#line 17 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mb-7\">\r\n                <img src=\"/imgs/one.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 621, "\"", 627, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"transition ease-in-out duration-150 hover:shadow-xl flex flex-col py-9 px-2 overflow-hidden\">\r\n                    <h1 class=\"font-serif text-xl pb-2\">");
#nullable restore
#line 22 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"font-serif text-md font-bold pb-3\">");
#nullable restore
#line 23 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
                                                            Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 933, "\"", 941, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "865707ecd7e5d3b7bd350eec7acaade33abc04146135", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 31 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"font-serif text-3xl md:text-4xl pb-4 text-center text-red-500 pb-10\">No Blog Posts</h1>\r\n");
#nullable restore
#line 35 "C:\Users\Aconte\Desktop\dot_net\DentistApp\dentistapp\Views\Blog\Bloglist.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DentistApp.Models.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
