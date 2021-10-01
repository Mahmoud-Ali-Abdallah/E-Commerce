using eCommerce.CoreBusiness.Models;
using System.Collections.Generic;

namespace eCommerce.UseCases.AdminPortal.ProcessedOrderScreen
{
    public interface IViewProcessedOrdersUseCase
    {
        IEnumerable<Order> Execute();
    }
}