#pragma checksum "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea6addde8e1c43cafc13fa9ecc9046f9580b8f5a"
// <auto-generated/>
#pragma warning disable 1591
namespace eCommerce.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using eCommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using eCommerce.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using eCommerce.Web.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\_Imports.razor"
using eCommerce.Web.Common.Controls;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.OpenComponent<eCommerce.Web.Shared.TopNavBar>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 10 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
