using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance_NJ_2017.Logic;

namespace LivePerformance_NJ_2017.Data
{
    public interface IContext
    {
        //Get all
        List<Partij> GetAllPartijen();
        List<Verkiezing> GetAllVerkiezingen();
        //Get by ID
        Partij GetPartijByID(int id);
        List<Uitslag> GetUitslagenVoorVerkiezing(int verkiezing_ID);
        //Insert
        bool InsertPartij(Partij partij);
        bool InsertVerkiezing(Verkiezing verkiezing);
        //Update
        bool UpdatePartij(Partij partij);
        bool UpdateUitslag(Uitslag uitslag);
    }
}
