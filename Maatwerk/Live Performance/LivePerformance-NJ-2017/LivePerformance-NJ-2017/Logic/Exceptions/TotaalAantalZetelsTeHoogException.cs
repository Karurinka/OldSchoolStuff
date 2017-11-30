using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic.Exceptions
{
    class TotaalAantalZetelsTeHoogException : Exception
    {
        public TotaalAantalZetelsTeHoogException(string message)
            : base(message)
        {
            message = "Het totaal aantal zetels is groter dan 150";
        }
    }
}
