using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Savory.Parser
{
    [TestClass]
    public class ListParserTest
    {
        [TestMethod]
        public void ListParser_Valid_Test()
        {
            var parser = new ListParser<int>(IntParser.Instance);
            var result = parser.Parse(" 1,2,3 , 3,4 ,,5, ,5");
            Assert.AreEqual(7, result.Count);
        }

        [TestMethod]
        public void ListParser_Invalid_Test()
        {
            var parser = new ListParser<int>(IntParser.Instance);
            List<int> result;
            Assert.IsFalse(parser.TryParse(" 1,2,3 , c3,4 ,5, 5", out result));
        }
    }
}
