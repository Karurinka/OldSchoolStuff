using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VogeltellersASP.Models.Logic
{
    public class Vogelsoort
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public string Afkorting { get; private set; }
        public DateTime BroedStart { get; private set; }
        public DateTime BroedEind { get; private set; }
        public int BroedpaarCijfer { get; private set; }

        //constructor
        public Vogelsoort(int id, string naam, string afkorting, DateTime broedStart, DateTime broedEind, int broedpaarCijfer)
        {
            this.ID = id;
            this.Naam = naam;
            this.Afkorting = afkorting;
            this.BroedStart = broedStart;
            this.BroedEind = broedEind;
            this.BroedpaarCijfer = broedpaarCijfer;
        }

        public Vogelsoort(int id, string afkorting)
        {
            this.ID = id;
            this.Afkorting = afkorting;
        }

        //methods
        public override bool Equals(object obj)
        {
            bool antwoord = false;

            if (obj is Vogelsoort)
            {
                Vogelsoort andere = (Vogelsoort)obj;

                bool zijnDeIDsGelijk = this.ID == andere.ID;
                bool zijnDeNamenGelijk = this.Naam == andere.Naam;
                bool zijnDeAfkortingenGelijk = this.Afkorting == andere.Afkorting;

                antwoord = zijnDeIDsGelijk && zijnDeNamenGelijk && zijnDeAfkortingenGelijk;
            }

            return antwoord;
        }
    }

    public class Vogelsoort_SorteerOpVogelnaam: IComparer<Vogelsoort>
    {
        public int Compare(Vogelsoort x, Vogelsoort y)
        {
            return string.Compare(x.Naam, y.Naam);
        }
    }

    public class Vogelsoort_SorteerOpBroedpaarCijfer : IComparer<Vogelsoort>
    {
        public int Compare(Vogelsoort x, Vogelsoort y)
        {
            if (x.BroedpaarCijfer < y.BroedpaarCijfer) return 1;
            else if (x.BroedpaarCijfer > y.BroedpaarCijfer) return -1;
            else return 0;
        }
    }
}