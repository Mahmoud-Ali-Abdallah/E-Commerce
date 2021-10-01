using eCommerce.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.UseCases.SearchProductScreen
{
    public interface ISearchProductUseCase
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
