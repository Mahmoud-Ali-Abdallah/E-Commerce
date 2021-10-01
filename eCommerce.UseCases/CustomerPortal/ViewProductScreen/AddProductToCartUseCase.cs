using eCommerce.UseCases.PluginInterfaces.DataStore;
using eCommerce.UseCases.PluginInterfaces.StateStore;
using eCommerce.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.ViewProductScreen
{
    public class AddProductToCartUseCase : IAddProductToCartUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public AddProductToCartUseCase(
            IProductRepository productRepository,
            IShoppingCart shoppingCart,
            IShoppingCartStateStore  shoppingCartStateStore
            )
        {
            this.productRepository = productRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async void Execute(int productId)
        {
            var product = productRepository.GetProduct(productId);

            await shoppingCart.AddProductAsync(product);

            shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
