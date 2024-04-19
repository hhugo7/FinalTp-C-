using Hochart.RG.DAL.DAL;
using Hochart.RG.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochart.RG.DAL.Service
{
    public class EspionService 
    {
        private readonly IHochartDbContext _dbContext;

        public EspionService(IHochartDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AjouterEspion(string nom, string nomDeCode)
        {
            var nouvelEspion = new Espion { Nom = nom, NomDeCode = nomDeCode };
            _dbContext.Espions.Add(nouvelEspion);
            _dbContext.SaveChanges();
        }

        public void AjouterMission(string nomDeCode, string ville, int annee)
        {
            var espion = _dbContext.Espions.FirstOrDefault(e => e.NomDeCode == nomDeCode);
            if (espion != null)
            {
                var nouvelleMission = new Mission { Lieu = ville, Annee = annee };
                espion.Missions.Add(nouvelleMission);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("L'espion avec le nom de code spécifié n'existe pas.");
            }
        }
    }

}
