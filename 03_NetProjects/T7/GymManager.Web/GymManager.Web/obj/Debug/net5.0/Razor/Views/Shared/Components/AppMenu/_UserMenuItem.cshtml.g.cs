#pragma checksum "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca7a9689c4833815720325e6035ad5aef78c64c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AppMenu__UserMenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
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
#line 1 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
using GymManager.Core.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca7a9689c4833815720325e6035ad5aef78c64c", @"/Views/Shared/Components/AppMenu/_UserMenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AppMenu__UserMenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GymManager.Web.Models.UserMenuItemViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
  
    var orderedChildMenuItems = Model.MenuItem.Items.OrderBy(x => x.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
 if(Model.MenuItem.Items.Count < 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 254, "\"", 340, 2);
            WriteAttributeValue("", 262, "nav-link", 262, 8, true);
#nullable restore
#line 12 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 270, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 271, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                              Write(Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "aria-current=\"page\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" href=\"#\">");
#nullable restore
#line 12 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                           Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </li>\r\n");
#nullable restore
#line 14 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}
else
{
    string currentElementId = "menu-" + new Random().Next();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item dropdown\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 602, "\"", 704, 3);
            WriteAttributeValue("", 610, "nav-link", 610, 8, true);
            WriteAttributeValue(" ", 618, "dropdown-toggle", 619, 16, true);
#nullable restore
#line 20 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue(" ", 634, Model.MenuItem.IsMenuActive(Model.CurrentPageName) ? "active" : "", 635, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\"");
            BeginWriteAttribute("id", " id=\"", 714, "\"", 736, 1);
#nullable restore
#line 20 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 719, currentElementId, 719, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">");
#nullable restore
#line 20 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                                                                                                                                                             Write(Model.MenuItem.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <ul class=\"dropdown-menu\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 852, "\"", 887, 1);
#nullable restore
#line 21 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 870, currentElementId, 870, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 22 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
             foreach(var subMenu in Model.MenuItem.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1009, "\"", 1028, 1);
#nullable restore
#line 24 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
WriteAttributeValue("", 1016, subMenu.Url, 1016, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
                                                            Write(subMenu.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </li>\r\n");
#nullable restore
#line 28 "C:\Users\sarge\Desktop\Academia Punto Singular\DN5_Fabian_Garcia\03_NetProjects\T7\GymManager.Web\GymManager.Web\Views\Shared\Components\AppMenu\_UserMenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GymManager.Web.Models.UserMenuItemViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
