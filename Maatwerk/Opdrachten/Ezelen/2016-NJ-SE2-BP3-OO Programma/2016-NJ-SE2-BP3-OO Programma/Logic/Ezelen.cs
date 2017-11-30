using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_NJ_SE2_BP3_OO_Programma.Logic
{
    public class Ezelen
    {
        //properties
        public bool IemandHeeftEzel { get; private set; }
        public Speler Speler { get; private set; }
        private Random random = new Random();
        private List<Tegenstander> Tegenstanders = new List<Tegenstander>();
        private List<Kaart> alleKaarten = new List<Kaart>();

        //constructor
        public Ezelen()
        {
            //vul de lijst
            VulAlleKaarten();
            Speler = new Speler("Pietje");
        }

        //methods
        public void VulAlleKaarten()
        {
            //alle harten kaarten toevoegen
            alleKaarten.Add(new Kaart(Soort.Harten, Waarde.Aas));
            alleKaarten.Add(new Kaart(Soort.Harten, Waarde.Boer));
            alleKaarten.Add(new Kaart(Soort.Harten, Waarde.Heer));
            alleKaarten.Add(new Kaart(Soort.Harten, Waarde.Vrouw));

            //alle klaveren kaarten toevoegen
            alleKaarten.Add(new Kaart(Soort.Klaveren, Waarde.Aas));
            alleKaarten.Add(new Kaart(Soort.Klaveren, Waarde.Boer));
            alleKaarten.Add(new Kaart(Soort.Klaveren, Waarde.Heer));
            alleKaarten.Add(new Kaart(Soort.Klaveren, Waarde.Vrouw));

            //alle ruiten kaarten toevoegen
            alleKaarten.Add(new Kaart(Soort.Ruiten, Waarde.Aas));
            alleKaarten.Add(new Kaart(Soort.Ruiten, Waarde.Boer));
            alleKaarten.Add(new Kaart(Soort.Ruiten, Waarde.Heer));
            alleKaarten.Add(new Kaart(Soort.Ruiten, Waarde.Vrouw));

            //alle schoppen kaarten toevoegen
            alleKaarten.Add(new Kaart(Soort.Schoppen, Waarde.Aas));
            alleKaarten.Add(new Kaart(Soort.Schoppen, Waarde.Boer));
            alleKaarten.Add(new Kaart(Soort.Schoppen, Waarde.Heer));
            alleKaarten.Add(new Kaart(Soort.Schoppen, Waarde.Vrouw));
        }

        public void SpeelKaart(Kaart kaart)
        {
            if (Speler.GetHand().Contains(kaart))
            {

            }
        }

        public bool IsErEenWinnaar()
        {
            if (IemandHeeftEzel == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeelKaartenAanDeelnemer()
        {
            //get een random getal
            //get random item from list
            Kaart kaart = (alleKaarten[random.Next(alleKaarten.Count)]);

            //geef speler random kaart
            Speler.OntvangKaart(kaart);
        }

        public List<Kaart> GeefKaartenVanSpeler()
        {
            return Speler.GetHand();
        }
    }
}
