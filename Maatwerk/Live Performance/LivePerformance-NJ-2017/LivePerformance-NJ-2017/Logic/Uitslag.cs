using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic
{
    public class Uitslag: IComparable<Uitslag>
    {
        //properties
        public int ID { get; private set; }
        public int Stemmen { get; private set; }
        public int Zetels { get; private set; }
        public int Partij_ID { get; private set; }
        public string PartijNaam { get; private set; }

        //constructor
        public Uitslag(int id, string partijnaam, int partij_ID, int stemmen)
        {
            this.ID = id;
            this.PartijNaam = partijnaam;
            this.Partij_ID = partij_ID;
            this.Stemmen = stemmen;
        }

        public Uitslag(string partijNaam, int stemmen, int zetels)
        {
            this.PartijNaam = PartijNaam;
            this.Stemmen = stemmen;
            this.Zetels = zetels; 
        }

        public Uitslag(int id, int stemmen)
        {
            this.ID = id;
            this.Stemmen = stemmen;
        }

        //methods
        public int BerekenZetelsVoorPartij(int alleStemmen)
        {
            decimal antwoord;
            antwoord = Convert.ToDecimal(Stemmen) / Convert.ToDecimal(alleStemmen) * 150m;
            Zetels = Convert.ToInt32(antwoord);
            return Zetels;
        }
        
        public override string ToString()
        {
            return "Partij: " + PartijNaam + " stemmen: " + Stemmen + " zetels: " + Zetels;
        }

        public int CompareTo(Uitslag andereUitslag)
        {
            if (this.Zetels < andereUitslag.Zetels) return 1;
            else if (this.Zetels > andereUitslag.Zetels) return -1;
            else return 0;
        }
    }
}
