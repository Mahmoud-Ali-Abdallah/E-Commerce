using eCommerce.CoreBusiness.Models;
using eCommerce.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase
    {
        private readonly IShoppingCart shoppingCart;

        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public async Task<Order> Execute()
        {
            return await shoppingCart.GetOrderAsync();
        }
    }
}
