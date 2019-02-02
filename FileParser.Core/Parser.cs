using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileParser.Core
{
    public class Parser
    {
        private File _file;

        public string CreateJson(string fileName)
        {
            var list = new List<string>();
            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }

            foreach (var item in list)
            {
                CreateFile(item);
            }

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };
            var json = JsonConvert.SerializeObject(_file, serializerSettings);

            return json;
        }

        private void CreateFile(string item)
        {
            var contents = item.Split(',').ToList();
            var tag = contents[0].RemoveDoubleQuotes();

            switch (tag)
            {
                case "F":
                    _file = new File(contents);
                    break;
                case "E":
                    _file.Ender = new Ender(contents);
                    break;
                case "O":
                    _file.Orders.Add(new Order(contents));
                    break;
                case "B":
                    if (_file.Orders.Last().Buyer != null)
                        throw new InvalidFileException(Constants.MORE_THAN_ONE_BUYER_MESSAGE);

                    _file.Orders.Last().Buyer = new Buyer(contents);
                    break;
                case "T":
                    if (_file.Orders.Last().Timings != null)
                        throw new InvalidFileException(Constants.MORE_THAN_ONE_TIMING_MESSAGE);

                    _file.Orders.Last().Timings = new Timing(contents);
                    break;
                case "L":
                    _file.Orders.Last().Items.Add(new LineItem(contents));
                    break;
                default:
                    throw new InvalidFileException();
            }
        }
    }
}