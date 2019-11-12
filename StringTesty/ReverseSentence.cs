using System;
using System.Collections.Generic;
using System.Text;

namespace StringTesty
{
    public class ReverseSentence
    {
        public string ReverseSen(string input)
        {
            string[] strTab = input.Split(' ', '.', ',', ':');
            char[] charTab = input.ToCharArray();
            string resoult = "";
            foreach (char litera in charTab)
            {
                if (true)
                {

                }
            }

            //string[] reversedTab = new string[strTab.Length];
            //string resoult = "";
            //for (int i = 0; i <strTab.Length; i++)
            //{
            //    reversedTab[i] = strTab[strTab.Length-1 -i];
            //}
            //for (int i = 0; i < reversedTab.Length; i++)
            //{
            //    resoult += reversedTab[i];
            //}
            //return resoult;
        }
    }
}
