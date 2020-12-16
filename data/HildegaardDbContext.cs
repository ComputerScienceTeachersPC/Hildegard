using System;
using System.Collections.Generic;
using System.Text;
using data.Models;
using Microsoft.EntityFrameworkCore;

namespace data
{
    public class HildegaardDbContext : DbContext
    {
        public DbSet<SetClass> SetClasses { get; set; }
        public HildegaardDbContext(DbContextOptions<HildegaardDbContext> options)  : base(options)
        {
            // empty
        }

    }
        
}
