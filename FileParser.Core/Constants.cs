using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileParser.Core
{
    public class Constants
    {
        public const string MORE_THAN_ONE_FILE_MESSAGE = "Only one file is allowed.";
        public const string MORE_THAN_ONE_BUYER_MESSAGE = "Only one buyer is allowed per order.";
        public const string MORE_THAN_ONE_TIMING_MESSAGE = "Only one timing is allowed per order.";
        public const string MALFORMED_BUYER_MESSAGE = "The buyer record is malformed.";
        public const string MALFORMED_ENDER_MESSAGE = "The ender record is malformed.";
        public const string MALFORMED_FILE_MESSAGE = "The file record is malformed.";
        public const string MALFORMED_ITEM_MESSAGE = "The line item record is malformed.";
        public const string MALFORMED_ORDER_MESSAGE = "The order record is malformed.";
        public const string MALFORMED_TIMING_MESSAGE = "The timing record is malformed.";
        public const string NO_ENDER_RECORD_MESSAGE = "File has no ender record.";
        public const string MORE_THAN_ONE_ENDER_RECORD_MESSAGE = "File already has an ender record.";
        public const string UNRECOGNIZED_TAG_MESSAGE = "The record type is not recognized.";
    }
}
