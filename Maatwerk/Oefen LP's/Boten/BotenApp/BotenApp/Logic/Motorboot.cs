using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public class Motorboot : Boot
    {
        //properties
        public int Tankinhoud { get; private set; }
        public int Actieradius { get; private set; }

        //constructor
        public Motorboot(int id, string naam, decimal huurprijs, int registratienummer)
            : base(id, naam, huurprijs, registratienummer)
        {

        }

        public Motorboot(int id, string naam, decimal huurprijs, int registratienummer, int tankinhoud, int actieradius)
            : base(id, naam, huurprijs, registratienummer)
        {
            this.Tankinhoud = tankinhoud;
            this.Actieradius = actieradius;
        }

        //methods
        public Motorboot ActieradiusBerekenen(Motorboot motorboot)
        {
            int actieradius;
            actieradius = motorboot.Tankinhoud * 15;
            motorboot.Actieradius = actieradius;
            return motorboot;
        }

        public override string ToString()
        {
            return Naam + ", " + "Tankinhoud: " + Tankinhoud +  " liter, Actieradius: " + Actieradius;
        }
    }
}
