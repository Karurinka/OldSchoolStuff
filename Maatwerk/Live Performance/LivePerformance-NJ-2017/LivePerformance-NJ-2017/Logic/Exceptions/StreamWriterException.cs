using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance_NJ_2017.Logic.Exceptions
{
    class StreamWriterException : Exception
    {
        public StreamWriterException(string message)
            : base(message)
        {
            message = "Er is een fout opgetreden bij het opslaan, probeer het opnieuw";
        }
    }
}
