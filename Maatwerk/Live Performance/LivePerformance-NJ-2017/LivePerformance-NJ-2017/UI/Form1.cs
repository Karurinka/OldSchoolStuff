using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance_NJ_2017.Data;
using LivePerformance_NJ_2017.Logic;
using LivePerformance_NJ_2017.Logic.Exceptions;

namespace LivePerformance_NJ_2017
{
    public partial class lblCoalitie : Form
    {
        private App app;

        public lblCoalitie(IContext context)
        {
            InitializeComponent();
            app = new App(context);
            LaadtVerkiezingen();
        }

        public void LaadtVerkiezingen()
        {
            //eerst de listbox leeg maken
            lbVerkiezingen.Items.Clear();
            app.ClearAlleVerkiezingen();
            //dan opnieuw vullen
            foreach (Verkiezing v in app.VerkiezingenOphalen())
            {
                lbVerkiezingen.Items.Add(v);
            }
        }

        public void LaadtPartijen()
        {
            //eerst de listbox leeg maken
            lbPartijen.Items.Clear();
            app.ClearAllePartijen();
            //dan opnieuw vullen
            foreach (Partij p in app.PartijenOphalen())
            {
                lbPartijen.Items.Add(p);
            }
        }

        private void btnNieuweVerkiezing_Click(object sender, EventArgs e)
        {
            //zet de knoppen/texboxen op enabled zodat deze ingevuld kunnen worden
            gbVerkiezingToevogen.Enabled = true;
        }

        private void btnLaadtVerkiezing_Click(object sender, EventArgs e)
        {
            lbUitslagen.Items.Clear();
            app.ClearHuidigeUitslagen();

            if (lbVerkiezingen.SelectedItem != null)
            {
                Verkiezing verkiezing = lbVerkiezingen.SelectedItem as Verkiezing;

                foreach (Uitslag u in app.UitslagenOphalen(verkiezing))
                {
                    lbUitslagen.Items.Add(u);
                }
                LaadtPartijen();
            }
        }

        private void btnVoegNieuwePartijToe_Click(object sender, EventArgs e)
        {
            //zet de knoppen/texboxen op enabled zodat deze ingevuld kunnen worden
            gbPartijAanpassen.Enabled = true;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text != null && tbDatum.Text != null)
            {
                string naam = tbNaam.Text;
                DateTime datum = Convert.ToDateTime(tbDatum.Text);

                try
                {
                    app.VerkiezingToevoegen(new Verkiezing(naam, datum));
                    MessageBox.Show("Verkiezing toegevoegd in de database");
                }
                catch (InsertDatabaseException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //zet de enabled van de knoppen/textboxen uit zodat ze niet ingevuld kunnen worden
                gbVerkiezingToevogen.Enabled = false;


                //herlaadt de verkiezingen zodat de nieuwe daar ook in komt te staan
                LaadtVerkiezingen();
            }
        }

        private void btnBevestigPartij_Click(object sender, EventArgs e)
        {
            if (lbPartijen.SelectedItem != null)
            {
                Partij partij = lbPartijen.SelectedItem as Partij;
                try
                {
                    app.PartijAanpassen(new Partij(partij.ID, tbPartijNaam.Text, tbLijsttrekker.Text));
                    MessageBox.Show("Partij opgeslagen");
                }
                catch (UpdateDatabaseException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gbPartijAanpassen.Enabled = false;
                LaadtPartijen();
            }
            else
            {
                if (tbPartijNaam.Text != null && tbLijsttrekker.Text != null)
                {
                    string naam = tbPartijNaam.Text;
                    string lijsttrekker = tbLijsttrekker.Text;

                    try
                    {
                        app.PartijToevoegen(new Partij(naam, lijsttrekker));
                        MessageBox.Show("Partij opgeslagen");
                    }
                    catch (InsertDatabaseException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //zet de enabled van de knoppen/textboxen uit zodat ze niet ingevuld kunnen worden
                    gbPartijAanpassen.Enabled = false;

                    //herlaadt al de partijen zodat de nieuwe ook in de listbox komt te staan
                    LaadtPartijen();
                }
            }
        }

        private void btnBevestigUitslag_Click_1(object sender, EventArgs e)
        {
            if (lbUitslagen.SelectedItem != null)
            {
                Uitslag uitslag = lbUitslagen.SelectedItem as Uitslag;

                try
                {
                    app.UitslagAanpassen(new Uitslag(uitslag.ID, Convert.ToInt32(tbStemmen.Text)));
                    MessageBox.Show("Stemmen opgeslagen");
                }
                catch (UpdateDatabaseException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                gbUitslagenAanpassen.Enabled = false;
            }
        }

        private void btnPasPartijAan_Click(object sender, EventArgs e)
        {
            if (lbPartijen.SelectedItem != null)
            {
                gbPartijAanpassen.Enabled = true;

                Partij partij = lbPartijen.SelectedItem as Partij;

                tbPartijNaam.Text = partij.Naam;
                tbLijsttrekker.Text = partij.Lijsttrekker;
            }
        }

        private void btnPasUitslagAan_Click(object sender, EventArgs e)
        {
            if (lbUitslagen.SelectedItem != null)
            {
                gbUitslagenAanpassen.Enabled = true;

                Uitslag uitslag = lbUitslagen.SelectedItem as Uitslag;

                tbStemmen.Text = Convert.ToString(uitslag.Stemmen);
            }
        }

        private void btnBevestigUitslag_Click(object sender, EventArgs e)
        {
            if (tbStemmen.Text != null)
            {
                Uitslag uitslag = lbUitslagen.SelectedItem as Uitslag;
                try
                {
                    app.UitslagAanpassen(new Uitslag(uitslag.ID, Convert.ToInt32(tbStemmen.Text)));
                    MessageBox.Show("Uitslag aangepast");
                }
                catch (UpdateDatabaseException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //zet de enabled van groupbox uit
                gbUitslagenAanpassen.Enabled = false;               
            }

        }

        private void btnVoegPartijToeAanCoalitie_Click(object sender, EventArgs e)
        {
            if (lbUitslagen.SelectedItem != null)
            {
                Uitslag uitslag = lbUitslagen.SelectedItem as Uitslag;

                app.HuidigeCoalitieSamenstellen(uitslag);

                lbCoalitie.Items.Clear();
                foreach (Uitslag u in app.GetGesorteerdeHuidigeCoalitie())
                {
                    lbCoalitie.Items.Add(u);
                }
            }
        }

        private void btnExporteerCoalitie_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TXT| *.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        app.CoalitieExporteren(sfd.FileName);
                        MessageBox.Show("De coalitie is opgeslagen als tekstbestand", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (StreamWriterException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } 
        }

        private void btnBerekenCoalitie_Click(object sender, EventArgs e)
        {
            if (app.CoalitieSamenstellen() == true)
            {
                try
                {
                    MessageBox.Show("De meerderheid is behaaldt");
                    btnExporteerCoalitie.Enabled = true;
                }
                catch (TotaalAantalZetelsTeHoogException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("De coalitie kan niet gevormd worden, er zijn niet genoeg zetels");
            }
        }
    }
}
