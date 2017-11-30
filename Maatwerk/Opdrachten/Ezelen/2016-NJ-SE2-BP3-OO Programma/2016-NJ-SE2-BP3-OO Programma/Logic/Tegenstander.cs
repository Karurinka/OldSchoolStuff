using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_NJ_SE2_BP3_OO_Programma.Logic
{
    public class Tegenstander: IStrategie
    {
        //properties
        public string Naam { get; private set; }
        public int Score { get; private set; }
        public bool WinnendeHand { get; private set; }
        public bool Verloren { get; private set; }
        private List<Kaart> kaarten = new List<Kaart>();
        private List<Kaart> hand = new List<Kaart>();
        private Random random = new Random();
        //private IStrategie strategie;

        //constructor
        public Tegenstander(string naam)
        {
            this.Naam = naam;
        }

        public Tegenstander(string naam, int score)
        {
            this.Naam = naam;
            this.Score = score;
        }

        //methods
        public void VulKaarten()
        {
            //alle harten kaarten toevoegen
            kaarten.Add(new Kaart(Soort.Harten, Waarde.Aas));
            kaarten.Add(new Kaart(Soort.Harten, Waarde.Boer));
            kaarten.Add(new Kaart(Soort.Harten, Waarde.Heer));
            kaarten.Add(new Kaart(Soort.Harten, Waarde.Vrouw));

            //alle klaveren kaarten toevoegen
            kaarten.Add(new Kaart(Soort.Klaveren, Waarde.Aas));
            kaarten.Add(new Kaart(Soort.Klaveren, Waarde.Boer));
            kaarten.Add(new Kaart(Soort.Klaveren, Waarde.Heer));
            kaarten.Add(new Kaart(Soort.Klaveren, Waarde.Vrouw));

            //alle ruiten kaarten toevoegen
            kaarten.Add(new Kaart(Soort.Ruiten, Waarde.Aas));
            kaarten.Add(new Kaart(Soort.Ruiten, Waarde.Boer));
            kaarten.Add(new Kaart(Soort.Ruiten, Waarde.Heer));
            kaarten.Add(new Kaart(Soort.Ruiten, Waarde.Vrouw));

            //alle schoppen kaarten toevoegen
            kaarten.Add(new Kaart(Soort.Schoppen, Waarde.Aas));
            kaarten.Add(new Kaart(Soort.Schoppen, Waarde.Boer));
            kaarten.Add(new Kaart(Soort.Schoppen, Waarde.Heer));
            kaarten.Add(new Kaart(Soort.Schoppen, Waarde.Vrouw));
        }

        public void OntvangKaart(Kaart kaart)
        {
            hand.Add(kaart);
        }

        public bool SpeelKaart(Kaart kaart)
        {
            if (hand != null)
            {
                //get random item from list
                kaart = (hand[random.Next(hand.Count)]);

                return true;
            }
            return false;
        }

        public void VerwijderAlleKaarten()
        {
            kaarten.Clear();
        }

        public void VerhoogScore(int score)
        {
            int nieuweScore = score + 1;
        }

        public List<Kaart> BepaalTeSpelenKaart()
        {
            //get random item from list
            Kaart kaart = (kaarten[random.Next(kaarten.Count)]);

            hand.Add(kaart);

            return hand;
        }

        public override string ToString()
        {
            return Naam + " " + Score;
        }
    }
}
