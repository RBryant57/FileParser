using System;
using System.Configuration;
using FileParser.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileParser.Tests
{
    [TestClass]
    public class FileParserTest
    {
        private string testDirectory = ConfigurationManager.AppSettings.Get("TestFileDirectory");

        [TestMethod]
        public void ValidFileShouldGenerateJson()
        {
            var file = testDirectory + "ValidFile.txt";
            var parser = new Parser();

            var json = parser.CreateJson(file);
            Assert.IsFalse(String.IsNullOrEmpty(json));
        }

        [TestMethod]
        public void MoreThanTwoBuyersOnOrderShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidFileTwoB.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MORE_THAN_ONE_BUYER_MESSAGE);
        }

        [TestMethod]
        public void MoreThanTwoTimingsOnOrderShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidFileTwoT.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MORE_THAN_ONE_TIMING_MESSAGE);
        }

        [TestMethod]
        public void InvalidBuyerShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidBuyerFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MALFORMED_BUYER_MESSAGE);
        }

        [TestMethod]
        public void InvalidEnderShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidEnderFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MALFORMED_ENDER_MESSAGE);
        }

        [TestMethod]
        public void InvalidFileShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidFileFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MALFORMED_FILE_MESSAGE);
        }

        [TestMethod]
        public void InvalidLineItemShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidLineItemFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MALFORMED_ITEM_MESSAGE);
        }

        [TestMethod]
        public void InvalidOrderShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidOrderFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MALFORMED_ORDER_MESSAGE);
        }

        [TestMethod]
        public void InvalidTimingShouldNotGenerateJson()
        {
            var file = testDirectory + "InvalidTimingFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MALFORMED_TIMING_MESSAGE);
        }
    }
}