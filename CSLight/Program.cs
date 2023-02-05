using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 10);
            Console.WriteLine(randomNumber);
            int userInput;
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == randomNumber) Console.WriteLine("You are right!");
                else { Console.WriteLine("You are wrong"); }
            } while (userInput != randomNumber);
        }
    }
}
