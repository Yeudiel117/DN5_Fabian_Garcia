#pragma checksum "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T2\GymManager.Web\GymManager.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c484d0b6ea65dc15275d79b8df9466fbd0ef944"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c484d0b6ea65dc15275d79b8df9466fbd0ef944", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GymManager.Core.Members.Member>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T2\GymManager.Web\GymManager.Web\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("HeaderRight", async() => {
                WriteLiteral("\r\n\r\n        <form class=\"d-flex\">\r\n            <input class=\"form-control me-2\" type=\"search\" placeholder=\"Search\" arial-label=\"Search\" />\r\n            <button class=\"btn btn-outline-success\" type=\"submit\">Search</button>\r\n        </form>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n  <div class=\"container\">\r\n    <h1 class=\"mt-5\">Sticky footer with fixed navbar</h1>\r\n\r\n\r\n    ");
#nullable restore
#line 24 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T2\GymManager.Web\GymManager.Web\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_MemberList.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GymManager.Core.Members.Member>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
