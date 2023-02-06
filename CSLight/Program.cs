using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random
            /*            Random rand = new Random();
                        int randomNumber = rand.Next(0, 10);
                        Console.WriteLine(randomNumber);
                        int userInput;
                        do
                        {
                            userInput = Convert.ToInt32(Console.ReadLine());
                            if (userInput == randomNumber) Console.WriteLine("You are right!");
                            else { Console.WriteLine("You are wrong"); }
                        } while (userInput != randomNumber);*/

            // single rank arrays
            /*            int[] fiveArr = new int[5];
                        int[] customArr = { 1, 2, 3 };
                        for (int i = 0; i < fiveArr.Length; i++)
                        {
                            fiveArr[i] = i;
                        }
                        fiveArr.SetValue(10, 2);
                        fiveArr[2] = 100;
                        Console.WriteLine(string.Join(", ", fiveArr));
                        Console.WriteLine(string.Join(", ", customArr));*/

            //multi rank arrays
            /*            int[,] array4 = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
                        for (int i = 0; i < array4.GetLength(0); i++)
                        {
                            for (int j = 0; j < array4.GetLength(1); j++)
                            {
                                Console.Write(array4[i,j] + " ");
                            }
                            Console.WriteLine();
                        }*/

            // array manipulations
            /*            int[] bag = new int[1];
                        bag[0] = 12;
                        int[] tempBag = new int[bag.Length + 1];
                        for (int i = 0; i < bag.Length; i++)
                        {
                            tempBag[i] = bag[i];
                            Console.WriteLine(tempBag[i] + " значение из сумки");
                        }
                        Console.WriteLine(tempBag[tempBag.Length - 1] + " последнее значение");
                        tempBag[tempBag.Length - 1] = 13;
                        bag = tempBag;
                        Console.WriteLine(bag[1]); // изменилось последнее значение так как массивы - ссылочные объекты*/

            // foreach
            /*            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                        foreach (int number in numbers)
                        {
                            Console.Write(number + " ");
                        }*/

            // functions in C#
            /*            Console.WriteLine("Request for connection");
                        WriteError("No connection", ConsoleColor.Red);
                        WriteError("Check internet connection", ConsoleColor.DarkYellow);
                        WriteError("Try to reboot router");

                        Console.WriteLine(Sum(10, 12));

                        int sumOut;
                        AddWithOut(out sumOut, 20, 20);
                        Console.WriteLine(sumOut + " added with out");

                        int sumRef = 0;
                        AddWithRef(ref sumRef, 30, 30);
                        Console.WriteLine(sumRef + " added with ref");

                        // difference is when using ref we have to initialize variable, out creates memory storage by itself

                        int[] array = new int[5];
                        EdditArray(array, 2, 5);
                        Console.WriteLine(array[2]);
                        // arrays are used as linked objects w/o refs or outs 

                        int[] arrayToModify = new int [5];
                        arrayToModify = EdditArrayWithModification(arrayToModify, 2, 5);
                        Console.WriteLine(arrayToModify.Length + ", " + arrayToModify[2]);*/

            // method overloading
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(ResizeArr(array, 6).Length);

            int[,] array2 = new int[5, 5];
            Console.WriteLine(array2.Length);
            array2 = ResizeArr(array2, 10, 10);
            Console.WriteLine(array2.Length);

            int[] intArr = new int[] { 2, 3, 4 };
            Action<int> action = new Action<int>(ShowSquares);
            Array.ForEach(intArr, action);

        }
        static void WriteError(string text, ConsoleColor color = ConsoleColor.Green)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void AddWithOut(out int sum, int x, int y)
        {
            sum = x + y;
        }
        static void AddWithRef(ref int sum, int x, int y)
        {
            sum = x + y;
        }
        static void EdditArray(int[] array, int index, int value)
        {
            array[index] = value;
        }
        static int[] EdditArrayWithModification(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
        static int[] ResizeArr(int[] array, int size)
        {
            int[] tempArr = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                tempArr[i] = array[i];
            }
            Console.Write(string.Join(", ", tempArr));
            Console.WriteLine();
            return tempArr;
        }
        static int[,] ResizeArr(int[,] array, int x, int y)
        {
            int[,] tempArr = new int[x, y];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArr[i, j] = array[i, j];
                }
            }
            array = tempArr;
            return array;
        }
        private static void ShowSquares(int val) {
            Console.WriteLine("{0:f} squared = {1:d}", val, val*val) ;
        }
    }
}
