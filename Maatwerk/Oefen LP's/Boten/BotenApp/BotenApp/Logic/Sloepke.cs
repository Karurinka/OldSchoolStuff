using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BotenApp.Data;

namespace BotenApp.Logic
{
    public class Sloepke
    {
        //properties
        public Boot Boot { get; private set; }
        public Artiekel Artiekel { get; private set; }
        public Huurder HuidigeHuurder { get; private set; }
        public Huurcontract Huurcontract { get; private set; }
        private List<Huurcontract> alleHuurcontracten = new List<Huurcontract>();
        private List<Water> alleWateren = new List<Water>();
        private List<Artiekel> alleArtiekelen = new List<Artiekel>();
        private List<Boot> alleBoten = new List<Boot>();
        private List<Artiekel> huidigeArtiekelen = new List<Artiekel>();
        private List<ContractRegel> huidigeContractRegels = new List<ContractRegel>();
        private List<Water> huidigeWateren = new List<Water>();
        private IContext context;

        //constructor
        public Sloepke(IContext context)
        {
            this.context = context;
        }

        //methods
        //berekent de actieradius van een bepaalde motorboor
        public bool HuurcontractAanmaken(Huurder huurder, List<Artiekel> artiekelen, List<Water> wateren)
        {
            throw new NotImplementedException();
        }

        //kijkt in de lijst van alle huurcontracten om het juiste contract te zoeken
        public Huurcontract HuurcontractBekijken(Huurcontract huurcontract)
        {
            foreach (Huurcontract h in alleHuurcontracten)
            {
                if (h.ID == huurcontract.ID)
                {
                    return h;
                }
            }
            return null;
        }

        //voeg boten toe aan de huidige artiekelen lijst
        public List<Artiekel> VoegBotenToeAanHuidigeArtiekelen(Boot boot)
        {
            huidigeArtiekelen.Add(boot);
            return huidigeArtiekelen;
        }

        public List<Artiekel> VoegExtraArtiekelenToeAanHuidigeArtiekelen(Artiekel artiekel)
        {
            huidigeArtiekelen.Add(artiekel);
            return huidigeArtiekelen;
        }

        public List<Water> VoegWaterToeAanHuidigeWateren(Water water)
        {
            huidigeWateren.Add(water);
            return huidigeWateren; 
        }

        public void HuurcontractExporteren(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write(Huurcontract.ToString());
                foreach (ContractRegel c in huidigeContractRegels)
                {
                    writer.Write(c.ToString());
                }
            }
        }

        //SQL
        public List<Artiekel> GetAllExtraArtiekelen()
        {
            foreach (Artiekel a in context.GetAllExtraArtiekelen())
            {
                alleArtiekelen.Add(a);
            }
            return alleArtiekelen;
        }

        public List<Boot> GetAllBoten()
        {
            foreach (Motorboot mb in context.GetAllMotorboten())
            {
                mb.ActieradiusBerekenen(mb);

                alleBoten.Add(mb);
            }

            foreach (Spierkrachtaangedrevenboot sb in context.GetAllSpierkrachtaangedrevenboten())
            {
                alleBoten.Add(sb);
            }

            return alleBoten;
        }

        public List<Water> GetAllWateren()
        {
            foreach (Water w in context.GetAllWateren())
            {
                alleWateren.Add(w);
            }

            return alleWateren;
        }

        public List<Huurcontract> GetAllHuurcontracten()
        {
            foreach (Huurcontract h in context.GetAllHuurcontracten())
            {
                //huurder's naam moet in huurcontract komen te staan
                HuidigeHuurder = GetHuurder(h.Huurder_ID);
                Huurcontract = new Huurcontract(h.ID, HuidigeHuurder.Naam);
                alleHuurcontracten.Add(Huurcontract);
            }
            return alleHuurcontracten;
        }

        public Huurder GetHuurder(int id)
        {
            HuidigeHuurder = context.GetHuurderByID(id);
            return HuidigeHuurder;
        }

        public Huurcontract GetHuurcontract(int id)
        {
            Huurcontract = context.GetHuurcontractByID(id);
            return Huurcontract;
        }
    }
}
