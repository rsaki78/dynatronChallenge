﻿using Dyna.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dyna.API.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options): base(options) { }

        public DbSet<Customer> Customers { get; set; } = null!;
    }
}
