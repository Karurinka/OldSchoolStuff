using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic
{
    public class Coalitie
    {
        //properties
        public int ID { get; private set; }
        public string Premier { get; private set; }

        //constructor
        public Coalitie(string premier)
        {
            this.Premier = premier;
        }

        //methods
        public override string ToString()
        {
            return "Premier: " + Premier;
        }
    }
}
