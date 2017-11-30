using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotenApp.Logic;

namespace BotenApp.Data
{
    public interface IContext
    {
        //GetAll's

        List<ContractRegel> GetAllContractRegels();
        List<Artiekel> GetAllExtraArtiekelen();
        List<Huurcontract> GetAllHuurcontracten();
        List<Boot> GetAllMotorboten();
        List<Spierkrachtaangedrevenboot> GetAllSpierkrachtaangedrevenboten();
        List<Water> GetAllWateren();

        //GetByID's
        Boot GetBootByID(int id);
        ExtraArtiekel GetExtraArtiekelByID(int id);
        Huurcontract GetHuurcontractByID(int id);
        Huurder GetHuurderByID(int id);
        Water GetWaterByID(int id);

        //Inserts
        bool InsertHuurcontract(Huurcontract huurcontract);
        
    }
}
