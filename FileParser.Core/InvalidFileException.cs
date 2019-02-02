using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser
{
    public class InvalidFileException : Exception
    {
        public InvalidFileException() : base()
        {

        }

        public InvalidFileException(string message) : base(message)
        {

        }

        public InvalidFileException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}