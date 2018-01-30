﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Savory.Parser
{
    [TestClass]
    public class EnumParserTest
    {
        [TestMethod]
        public void ListParser_Valid_Test()
        {
            var parser = new EnumParser<Color>();
            var result = parser.Parse("Blue");
            Assert.AreEqual(Color.Blue, result);
        }

        [TestMethod]
        public void ListParser_Invalid_Test()
        {
            var parser = new EnumParser<Color>();
            Color result;
            Assert.IsFalse(parser.TryParse("blue", out result));
        }
    }

    enum Color
    {
        Red,
        Green,
        Blue
    }
}
