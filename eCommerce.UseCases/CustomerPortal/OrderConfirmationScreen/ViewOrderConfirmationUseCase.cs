﻿using eCommerce.CoreBusiness.Models;
using eCommerce.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        private readonly IOrderRepository orderRepository;

        public ViewOrderConfirmationUseCase(
            IOrderRepository orderRepository
            )
        {
            this.orderRepository = orderRepository;
        }
        public Order Execute(string uniqueId)
        {
            return orderRepository.GetOrderByUniqueId(uniqueId);
        }
    }
}
