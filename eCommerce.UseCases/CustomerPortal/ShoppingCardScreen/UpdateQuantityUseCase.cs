using eCommerce.CoreBusiness.Models;
using eCommerce.UseCases.PluginInterfaces.StateStore;
using eCommerce.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public class UpdateQuantityUseCase : IUpdateQuantityUseCase
    {
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public UpdateQuantityUseCase(
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore)
        {
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int productId, int quantity)
        {
            var order = await shoppingCart.UpdateQuantityAsync(productId, quantity);
            shoppingCartStateStore.BroadCastStateChange();

            return order;
        }
    }
}
