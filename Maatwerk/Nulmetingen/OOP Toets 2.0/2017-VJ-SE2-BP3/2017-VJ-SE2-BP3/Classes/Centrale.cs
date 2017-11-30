using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using _2017_VJ_SE2_BP3.Exceptions;
using _2017_VJ_SE2_BP3.Interfaces;

namespace _2017_VJ_SE2_BP3.Classes
{
    public class Centrale
    {
        //properties
        public decimal PrijsPerLiter { get; private set; }
        public decimal Starttarief { get; private set; }
        private List<Voertuig> Wagenpark;
        private List<Voertuig> Uitgeredenvoertuigen;
        public Voertuig Voertuig { get; private set; }
        private List<Rit> Ritten;

        //constructor
        public Centrale(decimal starttarief, decimal prijsperliter)
        {
            this.PrijsPerLiter = prijsperliter;
            this.Starttarief = starttarief;
        }

        //methods
        //hier wordt door middel van eens streamreader de bestanden ingelezen
        //en toegevoegd aan een list met alle voertuigen
        public List<Voertuig> LaadVoertuigenUitBestand()
        {
            //maak een nieuwe list aan waar de data komt te staan
            List<Voertuig> UitgelezenVoertuigen = new List<Voertuig>();

            //kijkt of het bestand bestaat
            if (File.Exists(@"voertuigen.csv"))
            {
                {
                    FileStream file =
                        File.Open(@"voertuigen.csv", FileMode.Open);

                    StreamReader reader = new StreamReader(file);

                    //kijkt voor elke lijn wat er staat en
                    //wordt toegevoegd aan de lijst
                    while (reader.EndOfStream == false)
                    {
                        var line = reader.ReadLine();
                        var value = line.Split(';');

                        if (value[0] == " Auto")
                        {
                            UitgelezenVoertuigen.Add(new Auto((value[1]), Convert.ToInt32(value[2]), Convert.ToInt32(value[3])));
                        }

                        if (value[0] == " Bestelwagen")
                        {
                            UitgelezenVoertuigen.Add(new Bestelwagen(value[1], Convert.ToInt32(value[2]), Convert.ToInt32(value[3]), Convert.ToInt32(value[4]), Convert.ToDecimal(value[5])));
                        }

                        if (value[0] == " Vrachtwagen")
                        {
                            UitgelezenVoertuigen.Add(new Vrachtwagen(value[1], Convert.ToInt32(value[2]), Convert.ToInt32(value[4]), Convert.ToDecimal(value[5])));
                        }
                    }

                    return Wagenpark = UitgelezenVoertuigen;
                }
            }
            //als er geen bestand is of het bestand is corrupt
            //wordt deze exception doorgegooid naar het form
            throw new InlezenVanBestandException();
        }

        //haalt een list op van alle voertuigen
        public List<Voertuig> GeefAlleVoertuigen()
        {
            return Wagenpark;
        }

        //haalt een list op van alle voertuigen die niet aan het rijden zijn
        public List<Voertuig> UitgeredenVoertuig()
        {
            Uitgeredenvoertuigen = new List<Voertuig>();
            foreach (Voertuig v in Wagenpark)
            {
                if (Voertuig.InGarage == true)
                {
                    Uitgeredenvoertuigen.Add(v);
                }
            }
            return Uitgeredenvoertuigen;
        }

        //hier wordt de rit gereserveerd, voor een voertuig die passagiers meeneemt
        public string ReserveerRit(int aantalpasagiers)
        {
            foreach (Voertuig v in Wagenpark)
            {
                if (v is IPersonenVervoerder)
                {
                    IPersonenVervoerder pv = (IPersonenVervoerder)v;
                    if (v.GetInGarage() == true && pv.GetAantalPassagiers() >= aantalpasagiers)
                    {
                        Voertuig.SetInGarage(false);
                        return v.Kenteken;
                    }
                }
            }
            //exception wordt doorgegooid naar het form, daar komt ook de try catch
            throw new GeenVoertuigBeschikbaarException();
        }

        //hier wordt een rit gereserveerd die gewicht en volume heeft, dus bijvoorbeeld de vrachtwagen
        public string ReserveerRit(int gewicht, decimal volume)
        {
            foreach (Voertuig v in Wagenpark)
            {
                if (v is IVrachtVervoerder)
                {
                    IVrachtVervoerder vv = (IVrachtVervoerder)v;
                    if (v.GetInGarage() == true && vv.GetMaximaalGewicht() >= gewicht && vv.GetLaadVolume() >= volume)
                    {
                        v.SetInGarage(false);
                        return v.Kenteken;
                    }
                }
            }

            //exception wordt doorgegooid naar het form, daar komt ook de try catch
            throw new ReserveerRitException();
        }

        public void ReserveerRitten(string kenteken)
        {
            Ritten.Add(new Rit(kenteken, DateTime.Now, Starttarief));
        }

        //hier wordt de rit afgerond en is het voertuig uitgereden
        public void RitAfronden(string kenteken, int kilometers)
        {
            Voertuig.SetInGarage(true);
        }
    }
}
