using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic
{
    public class Partij
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public string Lijsttrekker { get; private set; }

        //constructor
        public Partij(int id, string naam, string lijsttrekker)
        {
            this.ID = id;
            this.Naam = naam;
            this.Lijsttrekker = lijsttrekker;
        }

        public Partij(string naam, string lijsttrekker)
        {
            this.Naam = naam;
            this.Lijsttrekker = lijsttrekker;
        }

        //methods
        public override string ToString()
        {
            return Naam + ": " + Lijsttrekker;
        }
    }
}
