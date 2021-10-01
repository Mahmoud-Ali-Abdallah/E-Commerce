using eCommerce.CoreBusiness.Models;
using eCommerce.UseCases.PluginInterfaces.DataStore;
using eCommerce.UseCases.PluginInterfaces.UI;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.ShoppingCart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {
        private const string cstrShoppingCart = "eShop.shoppingCart";

        private readonly IJSRuntime iJSRuntime;
        private readonly IProductRepository productRepository;

        public ShoppingCart(
            IJSRuntime iJSRuntime,
            IProductRepository productRepository)
        {
            this.iJSRuntime = iJSRuntime;
            this.productRepository = productRepository;
        }
        public async Task<Order> AddProductAsync(Product product)
        {
            var order = await GetOrder();
            order.AddProduct(product.Id , 1 , product.Price);

            await SetOrder(order);
            return order;
        }

        public async Task<Order> DeleteProductAsync(int productId)
        {
            var order = await GetOrder();
            order.RemoveProduct(productId);
            await SetOrder(order);

            return order;
        }

        public Task EmptyAsync()
        {
            return this.SetOrder(null);
        }

        public async Task<Order> GetOrderAsync()
        {
            var order = await GetOrder();
            return order;
        }

        public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            await SetOrder(order);

            return order;
        }

        public async Task<Order> UpdateQuantityAsync(int productId, int quantity)
        {
            var order = await GetOrder();

            if (quantity < 0)
                return order;
            else if (quantity == 0)
                return await DeleteProductAsync(productId);


            var lineitem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);
            if (lineitem != null) lineitem.Quantity = quantity;

            /*foreach (var item in order.LineItems)
            {
                if (item.ProductId == productId)
                    item.Quantity = quantity;
            }*/

            await SetOrder(order);

            return order;

        }

        private async Task<Order> GetOrder()
        {
            Order order = null;

            string strOrder = await iJSRuntime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);
            if (!string.IsNullOrWhiteSpace(strOrder) && strOrder.ToLower() != "null")
                order = JsonConvert.DeserializeObject<Order>(strOrder);
            else
            {
                order = new Order();
                await SetOrder(order);
            }

            foreach (var item in order.LineItems)
            {
                item.Product = productRepository.GetProduct(item.ProductId);
            }

            return order;
        }

        private async Task SetOrder(Order order)
        {
            await iJSRuntime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart, JsonConvert.SerializeObject(order));
        }
    }
}
