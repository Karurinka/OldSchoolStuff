using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _2017_VJ_SE2_BP3.Exceptions
{
    class ReserveerRitException : Exception
    {
        public ReserveerRitException()
            : base()
        {

        }

        public ReserveerRitException(string message)
           : base(message)
        {
            message = "Er is op dit moment geen voertuig beschikbaar met het gewenste laad volume en gewicht";
        }

        public ReserveerRitException(String message, Exception innerException)
            : base(message, innerException)
        {

        }

        protected ReserveerRitException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
