using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceMan
{
    public partial class SpaceManForm : Form
    {
        SpaceMan spaceMan;
        private SpaceControl spaceControl;

        public SpaceManForm()
        {
            InitializeComponent();
            spaceControl = new SpaceControl();
            spaceMan = new SpaceMan("Buzz Lightyear", 45);
            lblNaam.Text = spaceMan.Naam;
            GenereerData();
        }

        public void GenereerData()
        {
            //spaceMan.VoegBezochtePlaneetToe(new Planeet("Zorg", true));
            //spaceMan.VoegBezochtePlaneetToe(new Planeet("Tatooine", true));
            //spaceMan.VoegBezochtePlaneetToe(new Planeet("Jupiter", false));
            //spaceMan.VoegBezochtePlaneetToe(new Planeet("Mars", false));
            //spaceMan.VoegBezochtePlaneetToe(new Planeet("Saturnus", false));

            spaceControl.HaalAlleSpaceMenOp();
        }

        private void btHaalPlaneten_Click(object sender, EventArgs e)
        {
            lbPlaneten.Items.Clear();
            foreach (Planeet p in spaceMan.HaalBezochteBewoondePlaneten())
            {
                lbPlaneten.Items.Add(p.Naam);
            }
            
        }
    }
}
