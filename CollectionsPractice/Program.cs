using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // for (int i = 0; i <= numArray.Length; i++)
            // {
            //     numArray[i] = i;
            // }

            // Why does this not work?!

            // Console.WriteLine(numArray[9]);

            string[] nameArr = {"Tim", "Martin", "Nikki", "Sara"};

            bool[] TrueFalse = new bool[10];

            for (int i = 0; i <= 9; i++)
            {
                if (i % 2 != 0)
                {
                    TrueFalse[i] = false;
                }
                else
                {
                    TrueFalse[i] = true;
                }
            }

            // Lists
            List<string> IceCreamFlavors = new List<string>();

            IceCreamFlavors.Add("Bubble Gum");
            IceCreamFlavors.Add("Raspberry");
            IceCreamFlavors.Add("Cocunut");
            IceCreamFlavors.Add("Rocky Road");
            IceCreamFlavors.Add("Mint");

            Console.WriteLine(IceCreamFlavors.Count);

            Console.WriteLine(IceCreamFlavors[2]);
            IceCreamFlavors.RemoveAt(2);

            Console.WriteLine(IceCreamFlavors.Count);

            // Dictionaries
            Random rand = new Random();
            Dictionary<string,string> FavIceCream = new Dictionary<string, string>();

            for (int i = 0; i < nameArr.Length; i++)
            {
                FavIceCream.Add(nameArr[i], IceCreamFlavors[rand.Next(4)]);
            }

            foreach (KeyValuePair<string,string> entry in FavIceCream)
            {
            Console.WriteLine(entry.Key + " - " + entry.Value);

            }
        }

    }
}
