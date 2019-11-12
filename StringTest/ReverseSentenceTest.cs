using NUnit.Framework;
using StringTesty;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringTest
{
    public class ReverseSentenceTest
    {
        ReverseSentence reverseSen = new ReverseSentence();
        [SetUp]
        public void Setup()
        {

        }
        [TestCase("Ala ma kota","kota ma Ala")]
        public void ReverseSenTest(string input, string expected)
        {
            var resoult = reverseSen.ReverseSen(input);
            Assert.AreEqual(expected, resoult);
        }
    }
}
