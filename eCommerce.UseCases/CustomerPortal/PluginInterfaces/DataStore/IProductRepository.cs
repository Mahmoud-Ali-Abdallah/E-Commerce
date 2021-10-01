using eCommerce.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts(string filter = null);
    }
}
