#pragma checksum "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bda081e18dd8c851ef4e2a28b1434286f35f566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Logout), @"mvc.1.0.razor-page", @"/Areas/Identity/Logout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bda081e18dd8c851ef4e2a28b1434286f35f566", @"/Areas/Identity/Logout.cshtml")]
    #nullable restore
    public class Areas_Identity_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1>");
#nullable restore
#line 8 "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml"
      
        if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <form class=\"form-inline\" asp-area=\"Identity\" asp-page=\"/Account/Logout\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 262, "\"", 317, 1);
#nullable restore
#line 12 "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml"
WriteAttributeValue("", 284, Url.Page("/", new { area = "" }), 284, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n                <button type=\"submit\" class=\"nav-link btn btn-link text-dark\">Click here to Logout</button>\r\n            </form>\r\n");
#nullable restore
#line 15 "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>You have successfully logged out of the application.</p>\r\n");
#nullable restore
#line 19 "C:\C#\Tutorials\InventoryBegin\Areas\Identity\Logout.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
