namespace eCommerce.UseCases.AdminPortal.ProcessOrderScreen
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}