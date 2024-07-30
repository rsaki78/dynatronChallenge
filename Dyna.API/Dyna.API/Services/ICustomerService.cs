using Dyna.API.Models;

namespace Dyna.API.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<Customer> GetCustomer(long id);

        Task UpdateCustomer(long id, Customer customer);

        Task<Customer> CreateCustomer(Customer customer);

        Task DeleteCustomer(long id);
    }
}
