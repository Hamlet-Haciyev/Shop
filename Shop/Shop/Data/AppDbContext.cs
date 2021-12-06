using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
