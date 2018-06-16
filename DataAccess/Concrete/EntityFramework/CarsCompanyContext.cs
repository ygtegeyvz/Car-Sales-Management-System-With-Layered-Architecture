using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CarsCompanyContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Fuels> Fuels { get; set; }
    }
}
