using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MA_shop.Models;
using Microsoft.EntityFrameworkCore;

namespace MA_shop.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Category> categories {get; set;}
        public DbSet<Product> products {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            /// for online DB
            optionsBuilder.UseSqlServer("Server=db40353.public.databaseasp.net; Database=db40353; User Id=db40353; Password=Q!k4n7=K+qE6; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
           

//for local DB

         //optionsBuilder.UseSqlServer("Server=.;Database=mvc-shop;Trusted_connection=True;TrustServerCertificate=True");
        }
        
    }
}