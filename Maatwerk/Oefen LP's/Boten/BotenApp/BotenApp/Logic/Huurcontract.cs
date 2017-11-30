using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public class Huurcontract
    {
        //properties
        public int ID { get; private set; }
        public int Huurder_ID { get; private set; }
        public DateTime VanDatum { get; private set; }
        public DateTime TotDatum { get; private set; }
        public string HuurderNaam { get; private set; }
        private List<ContractRegel> contractRegels = new List<ContractRegel>();
        private List<Water> teBevarenWateren = new List<Water>();

        //constructor
        public Huurcontract(int id, int huurder_ID, DateTime vanDatum, DateTime totDatum)
        {
            this.ID = id;
            this.Huurder_ID = huurder_ID;
            this.VanDatum = vanDatum;
            this.TotDatum = totDatum;
        }

        public Huurcontract(int id, int huurder_ID, DateTime vanDatum, DateTime totDatum, List<ContractRegel> contractRegels, List<Water> teBevarenWateren)
        {
            this.ID = id;
            this.Huurder_ID = huurder_ID;
            this.VanDatum = vanDatum;
            this.TotDatum = totDatum;
            this.contractRegels = contractRegels;
            this.teBevarenWateren = teBevarenWateren;
        }

        public Huurcontract(int id, string huurderNaam)
        {
            this.ID = id;
            this.HuurderNaam = huurderNaam;
        }

        //methods
        //public string HuurdernaamToString(Huurder huurder)
        //{
        //    return "Huurcontract ID: " + ID + " Huurdernaam: " + huurder.Naam;
        //}

        public override string ToString()
        {
            return "Huurcontract ID: " + ID + " Huurder: " + HuurderNaam;
        }
    }
}
