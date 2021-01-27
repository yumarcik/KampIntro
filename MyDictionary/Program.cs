using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original Dictionary Class
            Dictionary<int, string> Alphabet = new Dictionary<int, string>();
            Alphabet.Add(1,"a");
            Alphabet.Add(2, "b");

            // MyDictionary Class
            MyDictionary<int, string> MyAlphabet = new MyDictionary<int, string>();
            MyAlphabet.Add(1, "A");
            MyAlphabet.Add(3, "C");
        }
    }
}
