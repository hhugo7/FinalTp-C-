using Hochart.RG.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Hochart.RG.DAL.DAL
{
    public interface IHochartDbContext
    {
        DbSet<Espion> Espions { get; set; }
        DbSet<Mission> Missions { get; set; }

        void SaveChanges();
    }
}