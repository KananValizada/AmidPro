using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class AmidDbContext : DbContext
    {
        public AmidDbContext(DbContextOptions<AmidDbContext> options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
    }
}
