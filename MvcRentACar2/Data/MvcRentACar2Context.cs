#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRentACar2.Models;

namespace MvcRentACar2.Data
{
    public class MvcRentACar2Context : DbContext
    {
        public MvcRentACar2Context (DbContextOptions<MvcRentACar2Context> options)
            : base(options)
        {
        }

        public DbSet<MvcRentACar2.Models.Cars> Cars { get; set; }

        public DbSet<MvcRentACar2.Models.CarRentalTime> CarRentalTime { get; set; }
    }
}
