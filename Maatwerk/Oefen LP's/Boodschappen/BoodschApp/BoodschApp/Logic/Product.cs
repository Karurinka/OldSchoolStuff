using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoodschApp.Logic
{
    public class Product
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public string Hoeveelheid { get; private set; }

        //constructor
        public Product(int id)
        {
            this.ID = id;
        }

        public Product(int id, string naam, string hoeveelheid)
        {
            this.ID = id;
            this.Naam = naam;
            this.Hoeveelheid = hoeveelheid;
        }

        //methods
        public class SorteerOpLooproute : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return string.Compare(x.Naam, y.Naam);
            }
        }

        public override string ToString()
        {
            return Naam + "  " + Hoeveelheid;
        }

        public override bool Equals(object obj)
        {
            bool antwoord = false;

            if (obj is Product)
            {
                Product andere = (Product)obj;

                bool zijnDeIDsGelijk = this.ID.Equals(andere.ID);
                bool zijnDeNamenGelijk = this.Naam.Equals(andere.Naam);
                bool isDeHoeveelheidGelijk = this.Hoeveelheid.Equals(andere.Hoeveelheid);

                antwoord = zijnDeIDsGelijk && zijnDeNamenGelijk && isDeHoeveelheidGelijk;
            }
            return antwoord;
        }
    }
}
