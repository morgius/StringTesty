using System;
using System.Collections.Generic;
using System.Text;

namespace StringTesty
{
    public class StringCalculator
    {
        public Dictionary<char, int> CharDictionary { get; set;} = new Dictionary<char, int>();
        public string Input { get; set; }
        public StringCalculator(string input)
        {
            Input= input;
        }
        public static void FillDictionary(string input, Dictionary<char, int> dictionary)
        {
            
            foreach (char item in input)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }
        }
        public static int CheckCHarNumber(Dictionary<char, int> dictionary, char input)
        {
            int resoult = 0;
            if (dictionary.ContainsKey(input))
            {
                 resoult = dictionary[input];
            }
            return resoult;
        }
    }
}
