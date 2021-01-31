using Dictionaries;
using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, string> myDict = new MyDict<string, string>();

            myDict.Add("Talha", "Gamga");
            myDict.Add("Baran", "Gamga");    
            myDict.Add("Halil", "Yıldırım");
            myDict.Add("Denis", "Karayel");

            myDict.ShowKeysValues();




        }
    }
}
