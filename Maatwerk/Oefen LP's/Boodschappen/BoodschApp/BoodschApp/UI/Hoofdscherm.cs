using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoodschApp.Data;
using BoodschApp.Logic;
using static BoodschApp.Logic.Product;
using System.IO;

namespace BoodschApp
{
    public partial class Form1 : Form
    {
        private App app;
        private SorteerOpLooproute sorteer = new SorteerOpLooproute();
        private List<Product> huidigeProducten = new List<Product>();

        public Form1(IContext context)
        {
            InitializeComponent();
            ReloadForm(context);
            app = new App(context);
        }

        //methods
        public void ReloadForm(IContext context)

        {
            lbVakerBesteld.Items.Clear();
            lbProducten.Items.Clear();
            lbGerechten.Items.Clear();
            lbSupermarkten.Items.Clear();

            foreach (Lijst l in context.GetAllLijsten())
            {
                lbVakerBesteld.Items.Add(l);
            }

            foreach (Product p in context.GetAllProducten())
            {
                lbProducten.Items.Add(p);
            }

            foreach (Gerecht g in context.GetAllGerechten())
            {
                lbGerechten.Items.Add(g);
            }

            foreach (Supermarkt s in context.GetAllSupermarkten())
            {
                lbSupermarkten.Items.Add(s);
            }
        }

        private void btnSupermarkt_Click(object sender, EventArgs e)
        {
            if (lbSupermarkten.SelectedItem != null)
            {
                Supermarkt supermarkt = lbSupermarkten.SelectedItem as Supermarkt;
            }
        }

        private void btnProducten_Click(object sender, EventArgs e)
        {
            lbHuidigeProducten.Items.Clear();
            //app = new App(new Lijst());
            SorteerOpLooproute sorteer = new SorteerOpLooproute();

            if (lbProducten.SelectedItem != null)
            {

                Product product = lbProducten.SelectedItem as Product;
                //app.Lijst.AddToHuidigeProducten(product);
                huidigeProducten.Add(product);
                huidigeProducten.Sort(sorteer);

                foreach (Product p in huidigeProducten)
                {
                    lbHuidigeProducten.Items.Add(p);
                }
            }
        }

        private void btnGerechten_Click(object sender, EventArgs e)
        {
            //lbHuidigeProducten.Items.Clear();

            if (lbGerechten.SelectedItem != null)
            {
                List<Product> gerechtProducten = new List<Product>();
                Gerecht gerecht = lbGerechten.SelectedItem as Gerecht;

                gerechtProducten = app.GetAllProductenVoorGerecht(gerecht);
                gerechtProducten.Sort(sorteer);

                foreach (Product p in gerechtProducten)
                {
                    huidigeProducten.Add(p);
                    lbHuidigeProducten.Items.Add(p);
                }
            }
        }

        private void btnBestel_Click(object sender, EventArgs e)
        {
            app = new App(new Lijst());
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV| *.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        app.Lijst.BoodschappenlijstUitdraaien(sfd.FileName, huidigeProducten);
                        MessageBox.Show("Het boodschappenlijstje is opgeslagen", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Er is iets mis gegaan bij het opslaan, probeer opnieuw");
                    }
                }
            }
        }
    }
}
