using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bikes.Models;

    public class bikesContext : DbContext
    {
        public bikesContext (DbContextOptions<bikesContext> options)
            : base(options)
        {
        }

        public DbSet<bikes.Models.bike> bike { get; set; }
    }
