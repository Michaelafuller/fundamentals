using System;
using System.Collections.Generic;

namespace Puzzles
{
    public class Program
    {

        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] NewRand = new int[10];

            int min = NewRand[0];
            int max = NewRand[0];
            int sum = 0;

            for (int i = 0; i < NewRand.Length; i++)
            {
                NewRand[i] = rand.Next(5,25);

                if (NewRand[i] > max)
                {
                    max = NewRand[i];
                }

                if (NewRand[i] < min)
                {
                    min = NewRand[i];
                }
                sum = sum + NewRand[i];
            }
            Console.WriteLine("Max:");
            Console.WriteLine(max);
            Console.WriteLine("Min:");
            Console.WriteLine(min);
            Console.WriteLine("Sum:");
            Console.WriteLine(sum);
            return NewRand;
        }

        public static int TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int heads = 0;
            int tails = 0;

            if (rand.Next(10) > 5)
            {
                Console.WriteLine("Heads");
                heads++;
            }
            else 
            {
                Console.WriteLine("Tails");
                tails++;
            }

            int total = heads + tails; 

            return total;
        }

        public static void TossMultipleCoins(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                TossCoin(); 
            }
            
        }

        public static List<string> Names()
        {
            List<string> nameList = new List<string>();

            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");

            Random rand = new Random();

            Console.WriteLine("Second List");
            if (nameList.Contains("Todd"))
            {
                nameList.Remove("Todd");
                nameList.Insert(rand.Next(4), "Todd");
            }
            if (nameList.Contains("Tiffany"))
            {
                nameList.Insert(rand.Next(4), "Tiffany");
                nameList.Remove("Tiffany");
            }
            if (nameList.Contains("Geneva"))
            {
                nameList.Remove("Geneva");
                nameList.Insert(rand.Next(4), "Geneva");
            }
            if (nameList.Contains("Charlie"))
            {
                nameList.Remove("Charlie");
                nameList.Insert(rand.Next(4), "Charlie");
            }
            if (nameList.Contains("Sydney"))
            {
                nameList.Remove("Sydney");
                nameList.Insert(rand.Next(4), "Sydney");
            }

            foreach (string x in nameList)
            {
            Console.WriteLine(x);               
            }

            List<string> longNames = new List<string>();
            foreach (string x in nameList)
            {
                if (x.Length > 5)
                {
                    longNames.Add(x);
                }
            }
            return longNames;
        }

        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Names();
        }
    }
}
