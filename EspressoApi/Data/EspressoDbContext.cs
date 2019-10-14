using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EspressoApi.Models;

namespace EspressoApi.Data
{
    public class EspressoDbContext : DbContext
    {
        public EspressoDbContext(DbContextOptions<EspressoDbContext>options): base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
