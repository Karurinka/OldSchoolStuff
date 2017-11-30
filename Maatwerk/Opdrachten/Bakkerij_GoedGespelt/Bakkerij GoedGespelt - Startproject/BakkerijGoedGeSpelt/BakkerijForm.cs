using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakkerijGoedGeSpelt.Classes;

namespace BakkerijGoedGeSpelt
{
    public partial class bakkerijForm : Form
    {
        Bakkerij bakkerij = new Bakkerij("Pietje's bakkerij");
        Broodje broodje = new Broodje("Broodenne", 5.60f, "Lekker broodje");
        public bakkerijForm()
        {
            InitializeComponent();
            RealoadForm();
        }

        public void RealoadForm()
        {
            //bakkerij.LaadBroodsoortenUitBestand();

            //foreach (Brood b in bakkerij.LaadBroodsoortenUitBestand())
            //{
            //    lbBroodjes.Items.Add(b);
            //}
            //VulBroodSoortenComboBox();
            VulBelegComboBox();
        }

        public void VulBroodSoortenComboBox()
        {
            bakkerij.LaadBroodsoortenUitBestand();
        }

        public void VulBelegComboBox()
        {
            List<Beleg> belegsoorten = new List<Beleg>();
            belegsoorten.Add(new Beleg("Sla", BelegSoort.Groente, 0.1));
            belegsoorten.Add(new Beleg("Oude kaas", BelegSoort.Kaas, 0.15));
            belegsoorten.Add(new Beleg("Jong belegen", BelegSoort.Kaas, 0.1));
            belegsoorten.Add(new Beleg("Tomaat", BelegSoort.Groente, 0.05));
            belegsoorten.Add(new Beleg("Komkommer", BelegSoort.Groente, 0.1));
            belegsoorten.Add(new Beleg("Ham", BelegSoort.Vlees, 0.15));
            belegsoorten.Add(new Beleg("Salami", BelegSoort.Vlees, 0.15));
            belegsoorten.Add(new Beleg("Rookvlees", BelegSoort.Vlees, 0.2));
            belegsoorten.Add(new Beleg("Tonijnsalade", BelegSoort.Vis, 0.3));
            belegsoorten.Add(new Beleg("Brie", BelegSoort.Kaas, 0.25));
            belegsoorten.Add(new Beleg("Appel", BelegSoort.Fruit, 0.15));
            belegsoorten.Add(new Beleg("Gerookte zalm", BelegSoort.Vis, 0.45));

            cbBeleg.DataSource = belegsoorten;
            cbBeleg.DisplayMember = "Naam";
        }

        private void btMaakPrijsLijst_Click(object sender, EventArgs e)
        {
            bakkerij.MaakPrijsLijst(broodje.ToString(), @"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\Test.bin");
        }

        private void btSlaBroodjesOp_Click(object sender, EventArgs e)
        {
            bakkerij.SlaBroodjesOp(broodje, @"C:\Users\miche\Dropbox\Fontys\Maatwerk\Opdrachten\Bakkerij_GoedGespelt\Bakkerij GoedGespelt - Startproject\BakkerijGoedGeSpelt\bin\Debug\broodjes.bin");
        }

        private void btBroodjeAanmaken_Click(object sender, EventArgs e)
        {
            Broodje broodje = new Broodje(tbNaamBroodje.Text, cbBroodSoorten.SelectedIndex);
            
        }
    }
}
