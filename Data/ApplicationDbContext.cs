using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MA_shop.Data
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            /// for online DB
            optionsBuilder.UseSqlServer("Server=db38976.public.databaseasp.net; Database=db38976; User Id=db38976; Password=Nr9#-Ta6e3K+; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True; ");
           
//for local DB

           // optionsBuilder.UseSqlServer("Server=.;Database=mvc-shop;Trusted_connection=True;TrustServerCertificate=True");
        }
        
    }
}