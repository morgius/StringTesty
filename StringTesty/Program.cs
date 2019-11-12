using System;
using System.Collections.Generic;

namespace StringTesty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> CharColection = null; //new Dictionary<char, int>();
            StringCalculator.FillDictionary("Ala ma kotaAt", CharColection);
            int resoult = StringCalculator.CheckCHarNumber(CharColection,'A');
            int x = CharColection.Count;
            Console.WriteLine(resoult);
        }
        
    }
}
