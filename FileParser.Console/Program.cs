using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileParser.Core;

namespace FileParser
{
    class Program
    {

        static void Main(string[] args)
        {
            var parser = new Parser();

            var json = parser.CreateJson(@"c:\file.txt");
            Console.Write(json);
            Console.ReadKey();
        }

    }

}