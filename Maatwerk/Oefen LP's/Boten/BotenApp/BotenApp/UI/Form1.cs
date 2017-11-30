using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BotenApp.Logic;
using BotenApp.Data;

namespace BotenApp
{
    public partial class Form1 : Form
    {
        private Sloepke sloepke;
        private int waterCount = 0;

        public Form1(IContext context)
        {
            InitializeComponent();
            sloepke = new Sloepke(context);
            ReloadForm();
        }

        public void ReloadForm()
        {
            lbBoten.Items.Clear();
            lbExtraArtiekelen.Items.Clear();
            lbWateren.Items.Clear();
            lbHuurcontract.Items.Clear();
            lbEerdereHuurcontracten.Items.Clear();

        }

        private void btnExporteren_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TXT| *.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sloepke.HuurcontractExporteren(sfd.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Er is iets misgegaan met het opslaan, probeer het opnieuw.");
                    }
                }
            }
        }

        //inladen van de artiekelen, boten en eerdere huurcontracten
        private void btnBudget_Click(object sender, EventArgs e)
        {
            foreach (Artiekel a in sloepke.GetAllExtraArtiekelen())
            {
                lbExtraArtiekelen.Items.Add(a);
            }

            foreach (Boot b in sloepke.GetAllBoten())
            {
                lbBoten.Items.Add(b);
            }

            foreach (Water w in sloepke.GetAllWateren())
            {
                lbWateren.Items.Add(w);
            }

            foreach (Huurcontract h in sloepke.GetAllHuurcontracten())
            {
                lbEerdereHuurcontracten.Items.Add(h);
            }

            btnBudget.Enabled = false;
        }

        private void btnVoegBootToe_Click(object sender, EventArgs e)
        {
            // items toe voegen aan contractregel lijst
            Boot boot = lbBoten.SelectedItem as Boot;

            if (lbBoten.SelectedItem != null)
            {
                sloepke.VoegBotenToeAanHuidigeArtiekelen(boot);
                // items laten zien in de listbox
                lbHuurcontract.Items.Add(boot);
                btnVoegBootToe.Enabled = false;
            }
        }

        private void btnVoegArtiekelToe_Click(object sender, EventArgs e)
        {
            Artiekel artiekel = lbExtraArtiekelen.SelectedItem as Artiekel;

            if (lbExtraArtiekelen.SelectedItem != null)
            {
                sloepke.VoegExtraArtiekelenToeAanHuidigeArtiekelen(artiekel);
                lbHuurcontract.Items.Add(artiekel);
            }
        }

        private void btnVoegWaterToe_Click(object sender, EventArgs e)
        {
            Water water = lbWateren.SelectedItem as Water;

            if (lbWateren.SelectedItem != null)
            {
                if (waterCount >= 5)
                {
                    btnVoegWaterToe.Enabled = false;
                }
                else
                {
                    waterCount = waterCount + 1;
                    sloepke.VoegWaterToeAanHuidigeWateren(water);
                    lbHuurcontract.Items.Add(water);
                }
            }
        }
    }
}
