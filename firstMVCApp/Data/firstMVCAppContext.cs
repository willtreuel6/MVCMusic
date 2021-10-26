using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using firstMVCApp.Models;

namespace firstMVCApp.Data
{
    public class firstMVCAppContext : DbContext
    {
        public firstMVCAppContext (DbContextOptions<firstMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
