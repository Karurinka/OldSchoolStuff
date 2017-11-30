using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VogeltellersASP.Models.Logic;

namespace VogeltellersASP.Models.Data
{
    public interface IContext
    {
        List<Bezoek> GetAllBezoeken();
        List<Vogelsoort> GetAllVogelsoorten();
        List<Waarneming> GetAllWaarnemingen();
        Bezoek GetBezoekByID(int id);
        Vogelsoort GetVogelsoortByID(int id);
        Waarneming GetWaarnemingByID(int id);
        Project GetBezoekPerProject(int id);
        Bezoek GetWaarnemingPerBezoek(int id);
        bool InsertBezoek(Bezoek bezoek);
        bool InsertWaarneming(Waarneming waarneming);
        bool InsertProject(Project project);
    }
}