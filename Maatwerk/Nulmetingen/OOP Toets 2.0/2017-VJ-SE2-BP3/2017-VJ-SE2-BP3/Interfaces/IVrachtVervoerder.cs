using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_VJ_SE2_BP3.Interfaces
{
    interface IVrachtVervoerder
    {
        //haalt het maximale gewicht op
        int GetMaximaalGewicht();
        //haalt het maximale laad volume op
        decimal GetLaadVolume();
    }
}
