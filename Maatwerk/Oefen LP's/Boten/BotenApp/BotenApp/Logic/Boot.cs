using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public abstract class Boot : Artiekel
    {
        //properties
        public int Registratienummer { get; private set; }

        //constructor
        public Boot(int id, string naam, decimal huurprijs, int registratienummer) 
            : base(id, naam, huurprijs)
        {
            this.Registratienummer = registratienummer;
        }

        //methods
    }
}
