using System;
using System.Collections.Generic;
using System.Configuration;
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
            var file = ConfigurationManager.AppSettings.Get("TestFileDirectory") + "ValidFile.txt";

            var json = parser.CreateJson(file);
            Console.Write(json);
            Console.ReadKey();
        }

    }

}