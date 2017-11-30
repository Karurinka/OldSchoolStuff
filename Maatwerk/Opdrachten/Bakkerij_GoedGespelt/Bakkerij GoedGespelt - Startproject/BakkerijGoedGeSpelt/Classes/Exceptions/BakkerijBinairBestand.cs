using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijGoedGeSpelt.Classes.Exceptions
{
    class BakkerijBinairBestand : Exception
    {
        public BakkerijBinairBestand()
        {

        }

        public BakkerijBinairBestand(string message)
        : base(message)
        {
            message = "Er is een fout opgetreden bij het inladen van het bestand";
        }
    }
}
