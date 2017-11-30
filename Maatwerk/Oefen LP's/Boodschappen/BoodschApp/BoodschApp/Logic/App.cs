using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoodschApp.Data;

namespace BoodschApp.Logic
{
    public class App
    {
        //properties
        public Product Product { get; private set; }
        public Gerecht Gerecht { get; private set; }
        public Lijst Lijst { get; private set; }
        public Supermarkt Supermarkt { get; private set; }
        private IContext context;

        //constructor
        public App(IContext context)
        {
            this.context = context;
        }

        public App(Lijst lijst)
        {
            this.Lijst = lijst;
        }

        public App()
        {

        }

        //methods
        public void VoegProductenToeAanHuidigeProducten(Product product)
        {
            Lijst.VoegProductToeAanHuidigProduct(product);
        }

        public List<Product> GetAllProductenVoorGerecht(Gerecht gerecht)
        {
            List<Product> producten;
            producten = context.GetProductenVoorGerecht(gerecht.ID);
            return producten;
        }
    }
}
