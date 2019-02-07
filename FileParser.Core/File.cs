using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class File
    {
        public string Date { get; set; }
        public string Type { get; set; }
        public List<Order> Orders { get; set; }
        public Ender Ender { get; set; }

        public File(List<string> input)
        {
            if (input.Count != 3)
                throw new InvalidOrderFileException(Constants.MALFORMED_FILE_MESSAGE);

            Date = input[1].RemoveDoubleQuotes(); 
            Type = input[2].RemoveDoubleQuotes(); 

            Orders = new List<Order>();
        }
    }
}