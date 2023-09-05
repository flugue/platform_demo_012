using Microsoft.AspNetCore.Mvc.RazorPages;
using PlatformDemo.Data.Models;
using PlatformDemo.Data.Services;

namespace PlatformDemo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ICustomerService CustomerService { get; set; }
        public List<Customer> Customers { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICustomerService customerService)
        {
            _logger = logger;
            CustomerService = customerService;
        }

        public async Task OnGet()
        {
            //get all customer from service
            Customers = await CustomerService.GetAllWithOrdersAsync();

        }
    }
}