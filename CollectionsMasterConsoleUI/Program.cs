using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50

            var rando = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(rando);

            //Print the first number of the array

            Console.WriteLine($"First number of array: {rando[0]}");

            //Print the last number of the array

            Console.WriteLine($"Last number of array: {rando[49]}");

            Console.WriteLine();

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(rando);

            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            //First reverse method
            Array.Reverse(rando);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(rando);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(rando);
            NumberPrinter(rando);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(rando);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(rando);
            NumberPrinter(rando);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            
            var numList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine("List Capacity: {0}", numList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(numList);
            //NumberPrinter(numList);

            //Print the new capacity
            Console.WriteLine("List Capacity: {0}", numList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" by accident your app should handle that!

            NumberChecker(numList);

            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numList);
            //NumberPrinter(numList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] convertedList = numList.ToArray();
            Console.WriteLine("Here's the 'list' as an array. Yea...it's the same: ");
            NumberPrinter(convertedList);

            //Clear the list
            Array.Clear(convertedList, 0, convertedList.Length);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
                foreach (int number in numbers)
                {
                    if (number % 3 == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }                   
                }
        }

        private static void OddKiller(List<int> numberList)
        {
            var tempNumList = new List<int>();
            for(int i = numberList.Count - 1; i >= 0 ; i--)
            {
                if (numberList[i] % 2 == 0)
                    {
                        tempNumList.Add(numberList[i]);
                    }             
            }

            numberList.Clear();

            for(int i = tempNumList.Count - 1; i >= 0 ; i--)
            {
                numberList.Add(tempNumList[i]);
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList)
        {
            Console.WriteLine("What number will you search for in the number list?");

            int numInput;

            while (true)
            {
                //Check user input to be sure an int is entered. If not, it ask for a number again
                if (int.TryParse(Console.ReadLine(), out numInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number: ");
                }
            }

            if (numberList.Contains(numInput))
            {
                Console.WriteLine($"{numInput} is on the list! Check it out! ");
                Console.WriteLine("-------------------");

                Console.WriteLine("All Numbers:");
                //Print all numbers in the list
                NumberPrinter(numberList);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Not a number on the list!");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0,51);
            }
        }       

        private static void ReverseArray(int[] array)
        {
            var reverseArray = new int[array.Length];
            var r = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverseArray[r] = array[i];
                r++;
            }

            for (int j = 0; j < reverseArray.Length; j++)
            {
                array[j] = reverseArray[j];
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
