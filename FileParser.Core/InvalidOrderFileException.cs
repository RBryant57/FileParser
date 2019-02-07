using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    public class InvalidOrderFileException : Exception
    {
        public InvalidOrderFileException() : base()
        {

        }

        public InvalidOrderFileException(string message) : base(message)
        {

        }

        public InvalidOrderFileException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}