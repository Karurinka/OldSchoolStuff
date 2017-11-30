using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoodschApp.Logic
{
    public class Supermarkt
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }

        //constructor
        public Supermarkt(int id, string naam)
        {
            this.ID = id;
            this.Naam = naam;
        }

        //methods
        public override string ToString()
        {
            return Naam;
        }
    }
}
