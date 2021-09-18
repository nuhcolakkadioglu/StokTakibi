using Microsoft.EntityFrameworkCore;
using StokTakibi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakibi.DataAccess.Concrete.EntityFramework
{
   public class StokTakibiContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=StokTakibi;integrated security=true;");
        }
        public DbSet<StokKarti> StokKartis { get; set; }

    }
}
