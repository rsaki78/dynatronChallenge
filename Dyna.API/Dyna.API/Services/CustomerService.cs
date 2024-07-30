using Microsoft.EntityFrameworkCore;
using Dyna.API.Data;
using Dyna.API.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Dyna.API.Services
{ 
    public class CustomerService : ICustomerService
    {
        private readonly CustomerContext _context;
        public CustomerService(CustomerContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomer(long id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                throw new InvalidDataException("Customer does not exist");
            }

            return customer;
        }
        
        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task UpdateCustomer(long id, Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    throw new InvalidDataException("Customer does not exist");
                }
                else
                {
                    throw;
                }
            }
        }
        
        public async Task DeleteCustomer(long id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                throw new InvalidDataException("Customer does not exist");
            }

            customer.IsActive = false;

            await _context.SaveChangesAsync();
        }

        private bool CustomerExists(long id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
