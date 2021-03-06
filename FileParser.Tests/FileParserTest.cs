﻿using System;
using System.Configuration;
using FileParser.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileParser.Tests
{
    [TestClass]
    public class FileParserTest
    {
        private readonly string _testDirectory = ConfigurationManager.AppSettings.Get("TestFileDirectory");

        [TestMethod]
        public void ValidFileShouldGenerateJson()
        {
            var file = _testDirectory + "ValidFile.txt";
            var parser = new Parser();

            var json = parser.CreateJson(file);
            Assert.IsFalse(String.IsNullOrEmpty(json));
        }

        [TestMethod]
        public void ValidFileWithBlankLinesShouldGenerateJson()
        {
            var file = _testDirectory + "ValidBlankFile.txt";
            var parser = new Parser();

            var json = parser.CreateJson(file);
            Assert.IsFalse(String.IsNullOrEmpty(json));
        }

        [TestMethod]
        public void ValidFileWithRandomCaseShouldGenerateJson()
        {
            var file = _testDirectory + "ValidRandomCaseFile.txt";
            var parser = new Parser();

            var json = parser.CreateJson(file);
            Assert.IsFalse(String.IsNullOrEmpty(json));
        }

        [TestMethod]
        public void InvalidContentsShouldNotGenerateJson()
        {
            var file = _testDirectory + "InvalidFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.IsFalse(String.IsNullOrEmpty(errorMessage));
        }

        [TestMethod]
        public void NoEnderShouldNotGenerateJson()
        {
            var file = _testDirectory + "InvalidFileNoEnder.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.NO_ENDER_RECORD_MESSAGE);
        }

        [TestMethod]
        public void MoreThanOneFileShouldNotGenerateJson()
        {
            var file = _testDirectory + "InvalidFileTwoFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MORE_THAN_ONE_FILE_MESSAGE);
        }

        [TestMethod]
        public void MoreThanOneEnderInFileShouldNotGenerateJson()
        {
            var file = _testDirectory + "InvalidFileTwoEnd.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
            {
                errorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }

            Assert.IsTrue(String.IsNullOrEmpty(json));
            Assert.AreEqual(errorMessage, Constants.MORE_THAN_ONE_ENDER_RECORD_MESSAGE);
        }

        [TestMethod]
        public void MoreThanOneBuyersOnOrderShouldNotGenerateJson()
        {
            var file = _testDirectory + "InvalidFileTwoB.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
        public void MoreThanOneTimingsOnOrderShouldNotGenerateJson()
        {
            var file = _testDirectory + "InvalidFileTwoT.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
            var file = _testDirectory + "InvalidBuyerFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
            var file = _testDirectory + "InvalidEnderFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
            var file = _testDirectory + "InvalidFileFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
            var file = _testDirectory + "InvalidLineItemFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
            var file = _testDirectory + "InvalidOrderFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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
            var file = _testDirectory + "InvalidTimingFile.txt";
            var parser = new Parser();
            var json = String.Empty;
            var errorMessage = String.Empty;

            try
            {
                json = parser.CreateJson(file);
            }
            catch (InvalidOrderFileException ex)
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