using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;

namespace PlatformDemo.Data.Services
{
    public class CustomerService : ICustomerService
    {
        public ApplicationDbContext Context { get; set; }

        public CustomerService(ApplicationDbContext context)
        {
            this.Context = context;
        }

        //Get all customers with Orders
        public async Task<List<Customer>> GetAllWithOrdersAsync()
        {
            return await Context.Customer
                .Include(c=>c.Orders).ToListAsync();
        }
    }
}
