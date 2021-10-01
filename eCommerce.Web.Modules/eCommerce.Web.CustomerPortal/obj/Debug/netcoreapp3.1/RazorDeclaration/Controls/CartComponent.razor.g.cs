// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace eCommerce.Web.CustomerPortal.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.UseCases.ViewProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.UseCases.PluginInterfaces.StateStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.UseCases.ShoppingCardScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.UseCases.OrderConfirmationScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.Web.Common.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.Web.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\_Imports.razor"
using eCommerce.Web.CustomerPortal.ViewModels;

#line default
#line hidden
#nullable disable
    public partial class CartComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\My Work\Study Blazor\Projects\eCommerce\eCommerce.Web.Modules\eCommerce.Web.CustomerPortal\Controls\CartComponent.razor"
       

    private int lineItemCount = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            shoppingCartStateStore.AddStateChangeListeners(HandleShoppingCartStateChange);
            lineItemCount = await shoppingCartStateStore.GetLineItemsCount();
            StateHasChanged();
        }
    }

    private async void HandleShoppingCartStateChange()
    {
        lineItemCount = await shoppingCartStateStore.GetLineItemsCount();
        StateHasChanged();
    }

    public void Dispose()
    {
        shoppingCartStateStore.RemoveStateChangeListeners(HandleShoppingCartStateChange);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShoppingCartStateStore shoppingCartStateStore { get; set; }
    }
}
#pragma warning restore 1591
