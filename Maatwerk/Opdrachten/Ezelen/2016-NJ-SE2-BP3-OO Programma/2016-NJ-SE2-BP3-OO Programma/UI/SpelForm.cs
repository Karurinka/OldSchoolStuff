using _2016_NJ_SE2_BP3_OO_Programma.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016_NJ_SE2_BP3_OO_Programma
{
    public partial class SpelForm : Form
    {
        private Ezelen ezelen;

        public SpelForm()
        {
            InitializeComponent();
            ezelen = new Ezelen();
            DeelKaartenAanSpeler();
            VulListbox();
        }

        public void DeelKaartenAanSpeler()
        {
            for (int i = 0; i < 4; i++)
            {
                ezelen.DeelKaartenAanDeelnemer();
            }
        }

        public void VulListbox()
        {
            foreach (Kaart k in ezelen.GeefKaartenVanSpeler())
            {
                lstKaartenSpeler.Items.Add(k);
            }
        }

        private void btnDoorgeven_Click(object sender, EventArgs e)
        {
            if (lstKaartenSpeler.SelectedItem != null)
            {
                Kaart kaart = lstKaartenSpeler.SelectedItem as Kaart;
            }
            else
            {
                MessageBox.Show("Selecteer een kaart om door te geven");
            }
        }

        private void btnNieuweRonde_Click(object sender, EventArgs e)
        {
            lstKaartenSpeler.Items.Clear();
            ezelen.Speler.VerwijderAlleKaarten();

            DeelKaartenAanSpeler();
            VulListbox();
        }
    }
}
