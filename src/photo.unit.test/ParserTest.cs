﻿using System;
using NUnit.Framework;

namespace photo.unit.test
{
    [TestFixture("Images/Canon PowerShot SX500 IS.JPG")]
    [TestFixture("Images/Nikon COOLPIX P510.JPG")]
    [TestFixture("Images/Panasonic Lumix DMC-FZ200.JPG")]
    [TestFixture("Images/Samsung SIII.jpg")]
    public class ParserTest
    {
        public ParserTest(string path)
        {
            _path = path;
            _parser = new Parser();
        }

        private readonly string _path;
        private readonly Parser _parser;

        [Test]
        public void Test_parse_return_some_data()
        {
            string data = _parser.Parse(_path);
            Console.Out.WriteLine(data);
            Assert.That(data, Is.Not.Null);
        }

        [Test]
        public void Test_parse2_return_some_data()
        {
            string data = _parser.Parse2(_path);
            Console.Out.WriteLine(data);
            Assert.That(data, Is.Not.Null);
        }
    }
}