using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class Timing
    {
        public string Start { get; set; }
        public string Stop { get; set; }
        public string Gap { get; set; }
        public string Offset { get; set; }
        public string Pause { get; set; }

        public Timing(List<string> input)
        {
            if (input.Count != 6)
                throw new InvalidFileException(Constants.MALFORMED_TIMING_MESSAGE);

            Start = input[1].RemoveDoubleQuotes();
            Stop = input[2].RemoveDoubleQuotes();
            Gap = input[3].RemoveDoubleQuotes();
            Offset = input[4].RemoveDoubleQuotes();
            Pause = input[5].RemoveDoubleQuotes();
        }
    }
}
