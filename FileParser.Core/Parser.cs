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
            using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (_file?.Ender != null)
                            throw new InvalidOrderFileException(Constants.MORE_THAN_ONE_ENDER_RECORD_MESSAGE);
                        CreateEntry(line);
                    }
                    if (_file.Ender == null)
                        throw new InvalidOrderFileException(Constants.NO_ENDER_RECORD_MESSAGE);
                }
            };

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };
            var json = JsonConvert.SerializeObject(_file, serializerSettings);

            return json;
        }

        private void CreateEntry(string item)
        {
            var contents = item.Split(',').ToList();
            var tag = contents[0].RemoveDoubleQuotes().ToLower();

            switch (tag)
            {
                case "f":
                    if (_file != null)
                        throw new InvalidOrderFileException(Constants.MORE_THAN_ONE_FILE_MESSAGE);

                    _file = new File(contents);
                    break;
                case "e":
                    _file.Ender = new Ender(contents);
                    break;
                case "o":
                    _file.Orders.Add(new Order(contents));
                    break;
                case "b":
                    if (_file.Orders.Last().Buyer != null)
                        throw new InvalidOrderFileException(Constants.MORE_THAN_ONE_BUYER_MESSAGE);

                    _file.Orders.Last().Buyer = new Buyer(contents);
                    break;
                case "t":
                    if (_file.Orders.Last().Timings != null)
                        throw new InvalidOrderFileException(Constants.MORE_THAN_ONE_TIMING_MESSAGE);

                    _file.Orders.Last().Timings = new Timing(contents);
                    break;
                case "l":
                    _file.Orders.Last().Items.Add(new LineItem(contents));
                    break;
                case "":
                    break;
                default:
                    throw new InvalidOrderFileException(Constants.UNRECOGNIZED_TAG_MESSAGE);
            }
        }
    }
}