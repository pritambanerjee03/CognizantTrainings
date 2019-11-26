using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class InvalidIndexException : ApplicationException
    {
        public InvalidIndexException()
        {
        }

        public InvalidIndexException(string message) : base(message)
        {
        }

        public InvalidIndexException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidIndexException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
