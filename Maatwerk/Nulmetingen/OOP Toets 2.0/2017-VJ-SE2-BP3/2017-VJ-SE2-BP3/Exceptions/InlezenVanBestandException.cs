using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _2017_VJ_SE2_BP3.Exceptions
{
    public class InlezenVanBestandException : Exception
    {
        public InlezenVanBestandException()
        : base()
        {

        }

        public InlezenVanBestandException(string message)
           : base(message)
        {
            message = "Er is een fout opgetreden bij het inlezen van het bestand";
        }

        public InlezenVanBestandException(String message, Exception innerException)
            : base(message, innerException)
        {

        }

        protected InlezenVanBestandException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
