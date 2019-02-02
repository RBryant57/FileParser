using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser.Core
{
    public static class FileParserStringExtensions
    {
        public static string RemoveDoubleQuotes(this String str)
        {
            return str.Replace("\"", "").Trim();
        }
    }
}
