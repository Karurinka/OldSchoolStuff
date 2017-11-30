using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoodschApp.Data;
using BoodschApp.Logic;

namespace BoodschApp.Data
{
    public interface IContext
    {
        List<Gerecht> GetAllGerechten();
        List<Lijst> GetAllLijsten();
        List<Product> GetAllProducten();
        List<Supermarkt> GetAllSupermarkten();
        List<Product> GetProductenVoorGerecht(int gerecht_ID);
        Gerecht GetGerechtByID(int id);
        Product GetProductByID(int id);

    }
}
