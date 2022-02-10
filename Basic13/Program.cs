using System;
using System.Collections.Generic;

namespace Basic13
{
    public class Program
    {
        // Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            for(int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Print all of the odd integers from 1 to 255.
        public static void PrintOdds()
        {
            for(int i = 1; i < 256; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        public static void PrintSum(int sum = 0)
        {
            for (int i = 0; i < 256; i++)
            {
                sum = sum + i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i] + sum;
            }
            int avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }

            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        public static int[] OddArray()
        {
            int size = (255/2) + 1;

            int[] oddNums = new int[size];

            int index = 0;
            for (int i = 1; i <= 255; i+=2)
            {
                oddNums[index] = i;
                index++;
            }
            return oddNums;
        }

            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    count++;
                }
            }
            return count;
        }

            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine(numbers[2]);
        }

            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(numbers[3]);
        }

            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            int average = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                
                sum = numbers[i] + sum;
            }
            average = sum / numbers.Length;
            Console.WriteLine("Min:");
            Console.WriteLine(min);
            Console.WriteLine("Max:");
            Console.WriteLine(max);
            Console.WriteLine("Average:");
            Console.WriteLine(average);
        }

            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
        public static void ShiftValues(int[] numbers)
        {
            int[] newArr = new int[numbers.Length];
            int index = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                newArr[index] = numbers[i];
                index ++;
            }
            Console.WriteLine(newArr[0]);
        }

            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        public static object[] NumToString(int[] numbers)
        {
            object[] objectArr = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    objectArr[i] = "Dojo";
                }
                else
                {
                    objectArr[i] = numbers[i];
                }
            }

            return objectArr;
        }



        public static void Main(string[] args)
        {
            PrintNumbers();

            PrintOdds();

            PrintSum();

            int[] arr = {1,2,3,4,5};
            LoopArray(arr);

            int[] arr2 = {-5, 0, 2, 7};
            Console.WriteLine(FindMax(arr2));

            int[] arr3 = {2,10,3};
            GetAverage(arr3);

            OddArray();

            int[] arr4 = {1,3,5,7};
            Console.WriteLine(GreaterThanY(arr4, 3));

            int[] arr5 = {1, 5, 10, -10};
            SquareArrayValues(arr5);

            int[] arr6 = {1, 5, 10, -2};
            EliminateNegatives(arr6);

            int[] arr7 = {1, 5, 10, 7, -2};
            MinMaxAverage(arr7);

            ShiftValues(arr7);

            int[] arr8 = {-1, -2, 3};
            Console.WriteLine(NumToString(arr8));


        }
    }
}
