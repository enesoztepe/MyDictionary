using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> sayilarList = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                sayilarList.Add(i);
            }
            MyDictionary<int, string> sayilarDictionary = new MyDictionary<int, string>();
            sayilarDictionary.Add(1, "bir");
            sayilarDictionary.Add(2, "iki");
            sayilarDictionary.Add(3, "üç");
            sayilarDictionary.Add(4, "dört");
            sayilarDictionary.Add(5, "beş");
            sayilarDictionary.Add(6, "altı");
            sayilarDictionary.Add(7, "yedi");

            Console.WriteLine(sayilarDictionary[1]);
            Console.WriteLine(sayilarDictionary["beş"]);

        }
    }
}
