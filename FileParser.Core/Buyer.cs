using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class Buyer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }

        public Buyer(List<string> input)
        {
            if (input.Count != 4)
                throw new InvalidFileException(Constants.MALFORMED_BUYER_MESSAGE);

            Name = input[1].RemoveDoubleQuotes();
            Address = input[2].RemoveDoubleQuotes();
            Zip = input[3].RemoveDoubleQuotes();
        }
    }
}
