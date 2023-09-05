using Microsoft.AspNetCore.Mvc.RazorPages;
using PlatformDemo.Data.Models;
using PlatformDemo.Data.Services;

namespace PlatformDemo.Web.Pages.Orders
{
	public class IndexModel : PageModel
    {
        public IOrderService OrderService { get; set; }
        public List<Order> Orders { get; set; }

		public IndexModel(IOrderService orderService)
		{
			OrderService = orderService;
		}

		public async Task OnGet(int id)
        {
            Orders = await OrderService.GetOrdersByCustomerId(id);
        }
    }
}
