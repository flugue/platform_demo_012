using PlatformDemo.Data.Models;

namespace PlatformDemo.Data.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllWithOrdersAsync();
    }
}
