using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic
{
    public class Verkiezing
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public DateTime Datum { get; private set; }
        public int AlleStemmen { get; private set; }
        private List<Uitslag> UitslagPerPartij = new List<Uitslag>();

        //constructor
        public Verkiezing(int id, string naam, DateTime datum)
        {
            this.ID = id;
            this.Naam = naam;
            this.Datum = datum;
        }

        public Verkiezing(string naam, DateTime datum)
        {
            this.Naam = naam;
            this.Datum = datum;
        }

        //methods
        public int BerekenAlleStemmen(List<Uitslag> uitslagen)
        {
            foreach (Uitslag u in uitslagen)
            {
                AlleStemmen = AlleStemmen + u.Stemmen;
            }
            return AlleStemmen;
        }

        public override string ToString()
        {
            return Naam + " " + Datum.Year;
        }
    }
}
