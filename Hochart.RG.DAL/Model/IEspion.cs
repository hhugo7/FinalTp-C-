
namespace Hochart.RG.DAL.Model
{
    public interface IEspion
    {
        int Id { get; set; }
        List<Mission> Missions { get; set; }
        string Nom { get; set; }
        string NomDeCode { get; set; }
    }
}