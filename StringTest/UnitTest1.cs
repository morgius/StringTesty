using NUnit.Framework;
using StringTesty;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        public Dictionary<char, int> CharDictionary = new Dictionary<char, int>();
        
        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase("Hello",4)]
        [TestCase("VVxx00###@@@",5)]
        public void FillDictionary(string input, int num)
        {
            Dictionary<char, int> CharDictionary = new Dictionary<char, int>();
            StringCalculator.FillDictionary(input, CharDictionary);
            int resoult = CharDictionary.Count;
            Assert.AreEqual(num, resoult);
        }
        [TestCase("Hello", 2,'l')]
        [TestCase("Ala ma kota", 0,'x')]
        [TestCase("VVxx00###@@@", 3,'@')]
        public void CheckCharNumber(string input,int num, char znak)
        {
            Dictionary<char, int> CharDictionary = new Dictionary<char, int>();
            StringCalculator.FillDictionary(input, CharDictionary);
            var resoult = StringCalculator.CheckCHarNumber(CharDictionary, znak);
            Assert.AreEqual(num, resoult);
        }
        [TestCaseSource(nameof(CounterExamples))]
        public void FillTestSecond(string text,Dictionary<char,int> expected)
        {
            Dictionary<char, int> CharDictionary = new Dictionary<char, int>();
            StringCalculator.FillDictionary(text, CharDictionary);
            CollectionAssert.AreEquivalent(expected, CharDictionary);
        }
        private static object[] CounterExamples =
         {
            new object[]
            {
                "Test",
                new Dictionary<char, int> {
                    {'T', 1},
                    {'e', 1},
                    {'s', 1},
                    {'t', 1},
                }
            },
            new object[]
            {
                "Wxx00###@@@",
                new Dictionary<char, int> {
                    {'W', 1},
                    {'x', 2},
                    {'0', 2},
                    {'#', 3},
                    {'@', 3}
                }
            }
        };
    }
}