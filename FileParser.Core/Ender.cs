using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class Ender
    {
        public string Process { get; set; }
        public string Paid { get; set; }
        public string Created { get; set; }

        public Ender(List<string> input)
        {
            if (input.Count != 4)
                throw new InvalidOrderFileException(Constants.MALFORMED_ENDER_MESSAGE);

            Process = input[1].RemoveDoubleQuotes();
            Paid = input[2].RemoveDoubleQuotes();
            Created = input[3].RemoveDoubleQuotes();
        }
    }
}
