using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public class ContractRegel
    {
        //properties
        public int ID { get; private set; }
        public int Huurcontract_ID { get; private set; }
        public int Artiekel_ID { get; private set; }
        public int Aantal { get; private set; }


        //constructor
        public ContractRegel(int id, int huurcontract_ID, int artiekel_ID, int aantal)
        {
            this.ID = id;
            this.Huurcontract_ID = huurcontract_ID;
            this.Artiekel_ID = artiekel_ID;
            this.Aantal = aantal;
        }

        //methods
    }
}
