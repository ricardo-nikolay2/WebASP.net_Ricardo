using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web_MVC_NET_5.Models;

namespace Web_MVC_NET_5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<Produksi> Produksis { get; set; }
            public DbSet<ProduksiStringID> ProduksiStringIDs { get; set; }
    }
}
