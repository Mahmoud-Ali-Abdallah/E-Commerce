using eCommerce.CoreBusiness.Models;
using System.Collections.Generic;

namespace eCommerce.UseCases.AdminPortal.OutstandingOrderScreen
{
    public interface IViewOutstandingOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}