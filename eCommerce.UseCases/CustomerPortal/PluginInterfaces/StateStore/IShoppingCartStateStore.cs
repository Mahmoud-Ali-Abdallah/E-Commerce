using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.UseCases.PluginInterfaces.StateStore
{
    public interface IShoppingCartStateStore : IStateStore
    {
        Task<int> GetLineItemsCount();
        void UpdateLineItemsCount();
        void UpdateProductQuantity();
    }
}
