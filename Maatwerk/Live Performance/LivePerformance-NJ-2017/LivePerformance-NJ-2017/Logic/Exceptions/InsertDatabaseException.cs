using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LivePerformance_NJ_2017.Logic.Exceptions
{
    class InsertDatabaseException : Exception
    {
        public InsertDatabaseException(string message)
            : base(message)
        {
            message = "Er is een fout opgetreden bij het invoeren in de database, probeer het opnieuw";
        }
    }
}
