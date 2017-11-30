using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMan
{
    class SpaceControl
    {
        // properties
        public List<SpaceMan> SpaceMen { get; private set; }

        // constructor
        public SpaceControl()
        {
            SpaceMen = new List<SpaceMan>();
        }

        // methods
        public void HaalAlleSpaceMenOp()
        {
            foreach (SpaceMan space in SpaceMen)
            {
                if (SpaceMen.Contains(space))
                {
                    Console.Write("Naam is al bezet");
                }
                else
                {
                    SpaceMen.Add(space);
                }
            }
        }
    }
}
