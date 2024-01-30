using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_InsertionSort_EdnalynnLaxa
{

    // Edna Lynn Laxa  ; Computer Programming V ; Assignment: Insertion Sort ; January 27 2024 
    internal class Program
    {
        //Globally Declared. 
        // Same accomplishments. 
        static Random random = new Random();
        static int size = 10; // Change the size of the array as needed
        static int minValue = 1; // Change the minimum value as needed
        static int maxValue = 100; // Change the maximum value as needed
        static int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);
        static void Main(string[] args)
        {
            //Insertion Sort is a simple and efficient sorting algorithm that works by building the final sorted array one element at a time.
            //It is called "Insertion Sort" because
            //it repeatedly takes an element from the unsorted part of the array and inserts it into its correct position in the sorted part of the array.


            // Display your array in it's unsorted form
            Console.WriteLine("Unsorted Array: ");
            Console.WriteLine("----------------");
            foreach (int numbers in randomArray)
            {
                Console.WriteLine(numbers);
            }
            Console.WriteLine();

            // Call your bubble sort method
            Console.WriteLine("Bubble Sort Method");
            Console.WriteLine("--------------------");
            BubbleSortArray(randomArray);
            foreach (int numbers in randomArray)
            {
                Console.WriteLine(numbers + " ");
            }
            Console.WriteLine();



            // Display your method after its been sorted
            Console.WriteLine("Insertion Sort Method");
            Console.WriteLine("-----------------------");
            InsertionSortArray(randomArray);
            foreach(int elementsinArray in randomArray)
            {
                Console.WriteLine(elementsinArray + " ");
            }
            Console.WriteLine();
        }
        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            if (size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }
        static void InsertionSortArray(int[] arr)
        {
            // Insertion Array builds the array up to par one element at a time. 
            // I watched the Insertion Sort Algorithm with Romanian folk Dance and was able to see visually what the computer may be executing. 
            // One transaction compares each element neighbor to each other , if the integer is greater than the other than it swaps accordingly and this is played out 
            //until each element are it's right placement area. The steps repeat and repeat. 

            // Calculate the length of the array 
            int arrayLength = arr.Length;

            for (int currentIndex = 1; currentIndex < arrayLength; currentIndex++)
            {

                // 1. Store the value of the current element in currentValue
                int currentValue = arr[currentIndex];

                // 2. Initialize previousIndex to one position before currentIndex
                int previousIndex = currentIndex - 1;

                // 3. Start a loop to move elements greater than currentValue
                //    one position ahead of their current position
                while (previousIndex >= 0 && arr[previousIndex] > currentValue)
                {
                    // 1. Shift the element to the right
                    arr[previousIndex + 1] = arr[previousIndex];

                    // 2. Decrement previousIndex to move to the previous element
                    previousIndex = previousIndex - 1;
                }

                // 4. Place currentValue at its correct position in the sorted part of the array
                arr[previousIndex + 1] = currentValue;
            }
        }
        static void BubbleSortArray(int[] array)
        {
            //Bubble sort array function accepts an integer collection as input & sorts it with a bubble sort algorithm. 

            // The outer loop executes num - 1 times where num is the length of the collection then the inner loop 
            //compares neighbors elements and swaps them if the sort is in the wrong order. 
            // After each execution is pass through the outer part of the loop , the largest member in the bubble is placed in its proper placement at the end of the 
            //collection. 
            //The transaction will continously travel through the range until the array is up to par. 

            int popNumbers = randomArray.Length; //variable "popNumbers" is utilized to store the length of the Array 
            for (int i = 0; i < popNumbers - 1; i++) // 
            {
                for (int z = 0; z < popNumbers - 1; z++) // initialize ; condition & modificaiton of increment; since popNumbers present the x amount in an array , when implementing "-1" this proposes the amount make certain that the last element is in its correct location 
                {
                    if (randomArray[z] > randomArray[z + 1]) // Implement a nested loop for bubble sort ; this proposes the computer to compare current & next element of variable z
                    {
                        int placeholder = randomArray[z]; // The current elment is deemed as a place holder 
                        randomArray[z] = randomArray[z + 1]; // The next element will then be assign to the current item 
                        randomArray[z + 1] = placeholder; // This allocate the next element in stored as a placeholder 

                        
                    }

                }

            }
        }
        //static void InsertionSortArray(int[] arraycollection)
        //{
        //    int numbers = randomArray.Length; 
        //    for(int i = 0; i < numbers; i++)
        //    {
        //        int currentNum = randomArray[i];
        //        int previousIn = i - 1; 
        //         while(previousIn >=0 && randomArray[previousIn] > currentNum)
        //        {
        //            randomArray[previousIn + 1] = randomArray[previousIn];
        //            previousIn--; 
        //        }
        //        randomArray[previousIn + 1] = currentNum; 

        //    }
        //}
    }
}
