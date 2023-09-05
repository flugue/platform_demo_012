using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;

namespace PlatformDemo.Data.Services
{
	public class OrderService : IOrderService
	{
		public ApplicationDbContext Context { get; set; }

		public OrderService(ApplicationDbContext context)
		{
			Context = context;
		}

		//GET ALL ORDERS BY CUSTOMER ID
		public async Task<List<Order>> GetOrdersByCustomerId(int customerId)
		{
			return await Context.Order.Where(o => o.CustomerId == customerId)
				.Include(o=>o.Customer).ToListAsync();
		}
	}
}
