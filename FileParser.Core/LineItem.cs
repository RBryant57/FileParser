using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class LineItem
    {
        public string SKU { get; set; }
        public string Quantity { get; set; }

        public LineItem(List<string> input)
        {
            if (input.Count != 3)
                throw new InvalidFileException(Constants.MALFORMED_ITEM_MESSAGE);

            SKU = input[1].RemoveDoubleQuotes();
            Quantity = input[2].RemoveDoubleQuotes();
        }
    }
}
