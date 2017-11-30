using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _2017_VJ_SE2_BP3.Exceptions
{
    class RittenOpslaanException : Exception
    {
        public RittenOpslaanException()
        : base()
        {

        }

        public RittenOpslaanException(string message)
           : base(message)
        {
            message = "Er is een fout opgetreden bij het opslaan van het bestand";
        }

        public RittenOpslaanException(String message, Exception innerException)
            : base(message, innerException)
        {

        }

        protected RittenOpslaanException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
