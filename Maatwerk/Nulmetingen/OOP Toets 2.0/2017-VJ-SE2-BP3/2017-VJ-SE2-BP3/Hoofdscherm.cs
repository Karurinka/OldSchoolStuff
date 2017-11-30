using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2017_VJ_SE2_BP3.Classes;
using _2017_VJ_SE2_BP3.Exceptions;

namespace _2017_VJ_SE2_BP3
{
    public partial class Hoofdscherm : Form
    {
        private Centrale centrale = new Centrale(10, 5);
        public Hoofdscherm()
        {
            InitializeComponent();
            LaadVoertuigenIn();
        }

        public void LaadVoertuigenIn()
        {
            try
            {
                centrale.LaadVoertuigenUitBestand();
                foreach (Voertuig v in centrale.GeefAlleVoertuigen())
                {
                    lstVoertuigen.Items.Add(v);
                }
            }
            catch (InlezenVanBestandException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNieuwCentraleAanmaken_Click(object sender, EventArgs e)
        {
            Centrale centrale = new Centrale(nudStartTarief.Value, nudPrijsPerLiter.Value);
        }

        private void btnRitAfronden_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (RittenOpslaanException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRitUitvoeren_Click(object sender, EventArgs e)
        {
            lstVoertuigenOnderweg.Items.Clear();
            try
            {
                if (nudRitGewicht.Value != 0 && nudRitVolume.Value != 0)
                {
                    centrale.ReserveerRitten(centrale.ReserveerRit(Convert.ToInt32(nudRitGewicht.Value), nudRitVolume.Value));
                    
                }
                if (nudRitPassagiers.Value != 0 && nudRitGewicht.Value != 0 && nudRitVolume.Value != 0)
                {
                    centrale.ReserveerRitten(centrale.ReserveerRit(Convert.ToInt32(nudRitPassagiers.Value)));
                    centrale.ReserveerRitten(centrale.ReserveerRit(Convert.ToInt32(nudRitGewicht.Value), nudRitVolume.Value));
                }
                if(nudRitPassagiers.Value != 0)
                {
                    centrale.ReserveerRitten(centrale.ReserveerRit(Convert.ToInt32(nudRitPassagiers.Value)));
                }
            }
            catch (ReserveerRitException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}



