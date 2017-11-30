using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using _2017_VJ_SE2_BP3.Exceptions;

namespace _2017_VJ_SE2_BP3.Classes
{
    class Rit
    {
        //properties
        public string Kenteken { get; private set; }
        public decimal GeredenKilometers { get; private set; }
        public DateTime StartDatum { get; private set; }
        public DateTime EindDatum { get; private set; }
        public decimal StartTarief { get; private set; }

        //constructor

        public Rit(string kenteken, DateTime startdatum, decimal starttarief)
        {
            this.Kenteken = kenteken;
            this.StartDatum = startdatum;
            this.StartTarief = starttarief;
        }

        public Rit(string kenteken, DateTime startdatum, DateTime einddatum, decimal geredenkilometers)
        {
            this.Kenteken = kenteken;
            this.StartDatum = startdatum;
            this.EindDatum = einddatum;
            this.GeredenKilometers = geredenkilometers;
        }

        //methods
        //bepaalt de kosten van de rit
        public decimal BepaalKosten(decimal starttarief, decimal geredenkilometers)
        {
            decimal kosten = starttarief * geredenkilometers;
            return kosten;
        }

        //hier worden alle ritten opgeslagen als een txt bestand
        public void SlaRittenOpAlsBestand()
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            save.FileName = "ritten";


            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = save.FileName;
                StreamWriter writer = new StreamWriter(File.Create(path));
                writer.Close();
            }

            throw new RittenOpslaanException();
        }

        //de overschrijving van de toString methode
        public override string ToString()
        {
            return "Start datum: " + Convert.ToString(StartDatum)
                   + ", gereden kilometers: " + Convert.ToString(GeredenKilometers);
        }
    }
}
