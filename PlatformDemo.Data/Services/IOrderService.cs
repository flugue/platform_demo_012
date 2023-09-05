using PlatformDemo.Data.Models;

namespace PlatformDemo.Data.Services
{
	public interface IOrderService
	{
		Task<List<Order>> GetOrdersByCustomerId(int customerId);
	}
}
