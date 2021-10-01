using eCommerce.CoreBusiness.Services;
using eCommerce.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.AdminPortal.ProcessOrderScreen
{
    public class ProcessOrderUseCase : IProcessOrderUseCase
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderService orderService;

        public ProcessOrderUseCase(
            IOrderRepository orderRepository,
            IOrderService orderService
            )
        {
            this.orderRepository = orderRepository;
            this.orderService = orderService;
        }

        public bool Execute(int orderId, string adminUserName)
        {
            var order = orderRepository.GetOrder(orderId);
            order.AdminUser = adminUserName;
            order.DateProcessed = DateTime.Now;

            if (orderService.ValidateProcessOrder(order))
            {
                orderService.ValidateUpdateOrder(order);
                return true;
            }

            return false;
        }
    }
}
