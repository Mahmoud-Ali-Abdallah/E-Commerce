using eCommerce.CoreBusiness.Models;
using eCommerce.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.AdminPortal.OutstandingOrderScreen
{
    public class ViewOutstandingOrderUseCase : IViewOutstandingOrderUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOutstandingOrderUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public IEnumerable<Order> Execute()
        {
            return orderRepository.GetOutstandingOrders();
        }
    }
}
