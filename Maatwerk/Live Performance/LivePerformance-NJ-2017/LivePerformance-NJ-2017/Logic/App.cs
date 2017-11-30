using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance_NJ_2017.Data;
using System.IO;
using LivePerformance_NJ_2017.Logic.Exceptions;

namespace LivePerformance_NJ_2017.Logic
{
    public class App
    {
        //properties
        private IContext context;
        private List<Uitslag> huidigeCoalitie = new List<Uitslag>();
        private List<Uitslag> huidigeUitslagen = new List<Uitslag>();
        private List<Verkiezing> alleVerkiezingen = new List<Verkiezing>();
        private List<Partij> allePartijen = new List<Partij>();

        //constructor
        public App(IContext context)
        {
            this.context = context;
        }

        //methods
        public List<Verkiezing> ClearAlleVerkiezingen()
        {
            alleVerkiezingen.Clear();
            return alleVerkiezingen;
        }

        public List<Partij> ClearAllePartijen()
        {
            allePartijen.Clear();
            return allePartijen;
        }

        public List<Uitslag> ClearHuidigeUitslagen()
        {
            huidigeUitslagen.Clear();
            return huidigeUitslagen;
        }

        //alle partijen uit de database halen
        public List<Partij> PartijenOphalen()
        {
            allePartijen = context.GetAllPartijen();
            return allePartijen;
        }

        //haalt alle verkiezingen op
        public List<Verkiezing> VerkiezingenOphalen()
        {
            alleVerkiezingen = context.GetAllVerkiezingen();
            return alleVerkiezingen;
        }

        //geeft de huidige coalitie gesorteerd terug
        public List<Uitslag> GetGesorteerdeHuidigeCoalitie()
        {
            huidigeCoalitie.Sort();
            return huidigeCoalitie;
        }

        //haalt alle uitslagen op voor 1 verkiezing
        public List<Uitslag> UitslagenOphalen(Verkiezing verkiezing)
        {
            huidigeUitslagen = context.GetUitslagenVoorVerkiezing(verkiezing.ID);

            foreach (Uitslag u in huidigeUitslagen)
            {
                // alle stemmen berekenen
                u.BerekenZetelsVoorPartij(verkiezing.BerekenAlleStemmen(huidigeUitslagen));

            }

            return huidigeUitslagen;
        }

        //insert partij in database
        public bool PartijToevoegen(Partij partij)
        {
            if (context.InsertPartij(partij) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //insert verkiezing in de database
        public bool VerkiezingToevoegen(Verkiezing verkiezing)
        {
            if (context.InsertVerkiezing(verkiezing) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //partij aanpassen in database
        public bool PartijAanpassen(Partij partij)
        {
            if (context.UpdatePartij(partij) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //uitslag updaten in database
        public bool UitslagAanpassen(Uitslag uitslag)
        {
            if (context.UpdateUitslag(uitslag) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //voegt een nieuwe uitslag toe aan de huidige coalitie list
        public List<Uitslag> HuidigeCoalitieSamenstellen(Uitslag uitslag)
        {
            if (huidigeCoalitie.Contains(uitslag) == false)
            {
                huidigeCoalitie.Add(uitslag);
            }
            return huidigeCoalitie;
        }

        //berekend het totaal aantal zetels van een uitslag
        //en berekend dan hoe veel er nodig voor de meerderheid
        public int BepaalMeerderheid()
        {
            int totaal = 0;
            foreach (Uitslag u in huidigeUitslagen)
            {
                totaal = totaal + u.Zetels;
            }

            int meerderheid = 0;

            try
            {
                if (totaal < 150)
                {
                    meerderheid = totaal / 2 + 1;
                }               
            }
            catch (Exception)
            {
                throw new TotaalAantalZetelsTeHoogException("Het totaal aantal zetels is groter dan 150");
            }

            return meerderheid;

        }

        public bool CoalitieSamenstellen()
        {
            //Uitslag uitslag = huidigeCoalitie.First() as Uitslag;
            int huidigeZetels = 0;

            //if (uitslag.Zetels > BepaalMeerderheid())
            //{
            //    return true;
            //}
            //return false;

            foreach (Uitslag u in huidigeCoalitie)
            {
                huidigeZetels = huidigeZetels + u.Zetels;
            }

            if (huidigeZetels > BepaalMeerderheid())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //exporteren van de listbox coalitie naar een tekst bestand
        public void CoalitieExporteren(string filename)
        {
            try
            {
                //pakt het eerste item uit de lijst, omdat deze gesorteerd is, is dit degene met de hoogste zetels
                Uitslag uitslag = huidigeCoalitie.First() as Uitslag;
                //geeft de partij terug die hoort bij de uitslag met het hoogste aantal zetels
                Partij partij = context.GetPartijByID(uitslag.Partij_ID) as Partij;

                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.Write("Coalitie voorstel" + Environment.NewLine);
                    writer.Write("============================" + Environment.NewLine);
                    writer.Write("" + Environment.NewLine);
                    writer.Write("Premier: ");
                    writer.Write(partij.Lijsttrekker + Environment.NewLine);

                    foreach (Uitslag u in huidigeCoalitie)
                    {
                        writer.Write(u.ToString() + Environment.NewLine);
                    }
                }
            }
            catch (Exception)
            {
                throw new StreamWriterException("Er is een fout opgetreden bij het opslaan, probeer opnieuw");
            }

        }

    }
}
