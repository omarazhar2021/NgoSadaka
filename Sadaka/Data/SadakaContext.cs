using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sadaka.Models;

namespace Sadaka.Data
{
    public class SadakaContext : DbContext
    {
        public SadakaContext (DbContextOptions<SadakaContext> options)
            : base(options)
        {
        }

        public DbSet<Sadaka.Models.Donation> Donation { get; set; }

        public DbSet<Sadaka.Models.Item> Item { get; set; }

        public DbSet<Sadaka.Models.Location> Location { get; set; }

        public DbSet<Sadaka.Models.Contact> Contact { get; set; }
    }
}
