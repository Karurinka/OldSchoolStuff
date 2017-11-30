using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoodschApp.Logic
{
    public class Gerecht
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public float Verpakking { get; private set; }
        private List<Product> alleProductenVoorGerecht;

        //constructor
        public Gerecht(int id, string naam)
        {
            this.ID = id;
            this.Naam = naam;
        }

        //methods
        public List<Product> GetAlleProductenVoorGerecht()
        {
            return alleProductenVoorGerecht;
        }

        public void SetAlleProductenVoorGerecht(List<Product> producten)
        {
            alleProductenVoorGerecht = producten;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
