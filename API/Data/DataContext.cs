using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) // will be passing some options to this particular class when we add it to our startup configuration, where we add it to our dependency injection container.
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }
}