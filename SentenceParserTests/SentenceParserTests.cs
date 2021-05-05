using Microsoft.VisualStudio.TestTools.UnitTesting;
using SentenceParserApp;

namespace SentenceParserTests
{
    [TestClass]
    public class SentenceParserTests
    {
        [TestMethod]
        public void Parser_can_receive_empty()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse("");

            Assert.AreEqual("", rslt);
        }

        [TestMethod]
        public void Parser_can_receive_null()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse(null);

            Assert.AreEqual("", rslt);
        }

        [TestMethod]
        public void Parser_can_receive_all_non_alphabetic()
        {
            var parser  = new SentenceParser();
            var rslt    =  parser.Parse(@"123213.....{}!!^%&$&%^$\/");

            Assert.AreEqual(@"123213.....{}!!^%&$&%^$\/", rslt);
        }

        [TestMethod]
        public void Parser_can_receive_all_alphabetic_and_non_alphabetic()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse(@" 'Cohesion' refers to what the class (or module) can do. Low cohesion....");

            Assert.AreEqual(@" 'C5n' r3s t0o w2t t1e c3s (o0r m4e) c1n d0o. L1w c5n....", rslt);
        }

        [TestMethod]
        public void ParseWord_can_receive_non_alphabetic()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse(@"....");

            Assert.AreEqual(@"....", rslt);
        }

        [TestMethod]
        public void ParseWord_can_parse_alphabethic_lenght_1()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse(@"a");

            Assert.AreEqual(@"a0a", rslt);
        }

        [TestMethod]
        public void ParseWord_can_parse_alphabethic_lenght_2()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse(@"it");

            Assert.AreEqual(@"i0t", rslt);
        }

        [TestMethod]
        public void ParseWord_can_parse_alphabethic_lenght_n()
        {
            var parser  = new SentenceParser();
            var rslt    = parser.Parse(@"goonies");

            Assert.AreEqual(@"g4s", rslt);
        }
    }
}
