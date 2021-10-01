#pragma checksum "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec00f5dfce1ef9a272910276444b07833720ce2"
// <auto-generated/>
#pragma warning disable 1591
namespace eCommerce.Web.AdminPortal.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using eCommerce.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using eCommerce.Web.Common.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using eCommerce.UseCases.AdminPortal.OutstandingOrderScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using eCommerce.UseCases.AdminPortal.ProcessedOrderScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\_Imports.razor"
using eCommerce.UseCases.AdminPortal.ProcessOrderScreen;

#line default
#line hidden
#nullable disable
    public partial class OrderComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
 if (Order != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "tr");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "td");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 5 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
             if (Order.DatePlaced.HasValue)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
                 Order.DatePlaced.Value.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
                                                              
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "td");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 11 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
             if (!Order.DateProcessed.HasValue)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "href", 
#nullable restore
#line 13 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
                                 $"processorder/{Order.OrderId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.AddContent(15, 
#nullable restore
#line 14 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
                     Order.OrderId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(16, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 16 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, 
#nullable restore
#line 19 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
                 Order.OrderId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
                              
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 22 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
             Order.CustomerCountry

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
             Order.CustomerStateProvince

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 24 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
             Order.CustomerCity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 25 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
             Order.CustomerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 27 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.AdminPortal\Controls\OrderComponent.razor"
       

    [Parameter]
    public Order Order { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
