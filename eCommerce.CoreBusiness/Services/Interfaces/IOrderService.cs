using eCommerce.CoreBusiness.Models;

namespace eCommerce.CoreBusiness.Services
{
    public interface IOrderService
    {
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInformation(string name, string address, string city, string provience, string country);
        bool ValidateProcessOrder(Order order);
        bool ValidateUpdateOrder(Order order);
    }
}