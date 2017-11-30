using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_NJ_SE2_BP3_OO_Programma.Logic
{
    public class Speler
    {
        //properties
        public string Naam { get; private set; }
        public int Score { get; private set; }
        //private List<Kaart> kaarten = new List<Kaart>();
        private List<Kaart> hand = new List<Kaart>();

        //constructor
        public Speler(string naam)
        {
            this.Naam = naam;
        }

        public Speler(string naam, int score)
        {
            this.Naam = naam;
            this.Score = score;
        }

        //methods
        public List<Kaart> GetHand()
        {
            return hand;
        }


        public void OntvangKaart(Kaart kaart)
        {
            hand.Add(kaart);
        }

        public bool SpeelKaart(Kaart kaart)
        {
            if (hand != null)
            {
                if (hand.Contains(kaart))
                {
                    return true;
                }
            }
            return false;
        }

        public void VerwijderAlleKaarten()
        {
            hand.Clear();
        }

        public int VerhoogScore()
        {
            Score = Score + 1;
            return Score;
        }

        public bool HeeftWinnendeHand()
        {
            throw new NotImplementedException();
        }

        public bool IsVerloren()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Naam + " " + Score;
        }
    }
}
