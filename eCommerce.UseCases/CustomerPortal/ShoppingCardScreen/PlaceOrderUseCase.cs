using eCommerce.CoreBusiness.Models;
using eCommerce.CoreBusiness.Services;
using eCommerce.UseCases.PluginInterfaces.DataStore;
using eCommerce.UseCases.PluginInterfaces.StateStore;
using eCommerce.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.UseCases.ShoppingCardScreen
{
    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderService orderService;
        private readonly IOrderRepository orderRepository;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public PlaceOrderUseCase(
            IOrderService orderService,
            IOrderRepository orderRepository,
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore
            )
        {
            this.orderService = orderService;
            this.orderRepository = orderRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<string> Execute(Order order)
        {
            if (orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                orderRepository.CreateOrder(order);

                await shoppingCart.EmptyAsync();

                shoppingCartStateStore.UpdateLineItemsCount();

                return order.UniqueId;
            }

            return null;
        }
    }
}
