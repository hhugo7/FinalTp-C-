using Hochart.RG.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochart.RG.DAL.DAL
{
    public class HochartDbContext : DbContext, IHochartDbContext
    {
        public DbSet<Espion> Espions { get; set; }
        public DbSet<Mission> Missions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=db_servicesecret;Uid=root;Pwd=;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
