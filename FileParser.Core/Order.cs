using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class Order
    {
        public string Date { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public Buyer Buyer { get; set; }
        public List<LineItem> Items { get; set; }
        public Timing Timings { get; set; }

        public Order(List<string> input)
        {
            if (input.Count != 4)
                throw new InvalidFileException(Constants.MALFORMED_ORDER_MESSAGE);

            Date = input[1].RemoveDoubleQuotes();
            Code = input[2].RemoveDoubleQuotes();
            Number = input[3].RemoveDoubleQuotes();

            Items = new List<LineItem>();
        }
    }
}