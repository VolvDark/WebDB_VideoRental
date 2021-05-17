using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDB_VideoRental.Models;

namespace WebDB_VideoRental.Data
{
    public class WebDB_VideoRentalContext : DbContext
    {
        public WebDB_VideoRentalContext (DbContextOptions<WebDB_VideoRentalContext> options)
            : base(options)
        {
        }

        public DbSet<WebDB_VideoRental.Models.employee> employee { get; set; }

        public DbSet<WebDB_VideoRental.Models.position> position { get; set; }

        public DbSet<WebDB_VideoRental.Models.genre> genre { get; set; }

        public DbSet<WebDB_VideoRental.Models.client> client { get; set; }

        public DbSet<WebDB_VideoRental.Models.cassette> cassette { get; set; }
    }
}
