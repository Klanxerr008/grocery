using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using grocery.Models;

namespace grocery.Data
{
    public class groceryContext : DbContext
    {
        public groceryContext (DbContextOptions<groceryContext> options)
            : base(options)
        {
        }

        public DbSet<grocery.Models.Products> Products { get; set; } = default!;
    }
}
