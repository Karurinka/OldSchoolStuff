using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic.Exceptions
{
    class UpdateDatabaseException : Exception
    {
        public UpdateDatabaseException(string message)
            : base(message)
        {
            message = "Er is iets misgegaan met het aanpassen, probeer het opnieuw";
        }
    }
}
