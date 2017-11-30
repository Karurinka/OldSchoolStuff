using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _2017_VJ_SE2_BP3.Exceptions
{
    public class GeenVoertuigBeschikbaarException : Exception
    {
        public GeenVoertuigBeschikbaarException()
            : base()
        {

        }

        public GeenVoertuigBeschikbaarException(string message)
           : base(message)
        {
            message = "Er is op dit moment geen voertuig beschikbaar";
        }

        public GeenVoertuigBeschikbaarException(String message, Exception innerException)
            : base(message, innerException)
        {

        }

        protected GeenVoertuigBeschikbaarException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
