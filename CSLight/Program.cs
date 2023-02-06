using System;
using System.Collections.Generic;
using System.Linq;

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
                        LearningFunctions.WriteError("No connection", ConsoleColor.Red);
                        LearningFunctions.WriteError("Check internet connection", ConsoleColor.DarkYellow);
                        LearningFunctions.WriteError("Try to reboot router");

                        Console.WriteLine(LearningFunctions.Sum(10, 12));

                        int sumOut;
                        LearningFunctions.AddWithOut(out sumOut, 20, 20);
                        Console.WriteLine(sumOut + " added with out");

                        int sumRef = 0;
                        LearningFunctions.AddWithRef(ref sumRef, 30, 30);
                        Console.WriteLine(sumRef + " added with ref");

                        // difference is when using ref we have to initialize variable, out creates memory storage by itself

                        int[] array = new int[5];
                        LearningFunctions.EdditArray(array, 2, 5);
                        Console.WriteLine(array[2]);
                        // arrays are used as linked objects w/o refs or outs 

                        int[] arrayToModify = new int[5];
                        arrayToModify = LearningFunctions.EdditArrayWithModification(arrayToModify, 2, 5);
                        Console.WriteLine(arrayToModify.Length + ", " + arrayToModify[2]);*/

            // method overloading
            /*            int[] array = { 1, 2, 3, 4, 5 };
                        Console.WriteLine(string.Join(", ", array));
                        Console.WriteLine(LearningFunctions.ResizeArr(array, 6).Length);

                        int[,] array2 = new int[5, 5];
                        Console.WriteLine(array2.Length); // before resize
                        array2 = LearningFunctions.ResizeArr(array2, 10, 10);
                        Console.WriteLine(array2.Length); // after resize

                        int[] intArr = new int[] { 2, 3, 4 };
                        Action<int> action = new Action<int>(LearningFunctions.ShowSquares);
                        Array.ForEach(intArr, action);*/

            // List collections
            /*            List<int> numbers = new List<int>();
                        numbers.Add(1);
                        numbers.Add(2);
                        numbers.Add(3);
                        numbers.Add(4);
                        numbers.Add(5);

                        numbers.AddRange(new int[] { 6, 7 }); // adds with shift "6" and "7" 

                        numbers.RemoveAt(4); // removes "5"

                        numbers.Add(4);

                        numbers.Remove(4); // removes first occurence of "4"

                        numbers.Insert(numbers.Count, 0); // any position can be an index insertion

                        Console.WriteLine($"\n{numbers.Count} is items q-ty of this List \n");

                        Console.WriteLine($"FYI: number 7 is currently at the position of {numbers.IndexOf(7) + 1}");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.WriteLine(numbers[i]);
                        }*/

            // FIFO, Queue
            /*            Queue<string> patients = new Queue<string>();
                        patients.Enqueue("Vasya");
                        patients.Enqueue("Leha");
                        patients.Enqueue("Nik");
                        patients.Enqueue("Roman");


                        foreach (var patient in patients)
                        {
                            Console.WriteLine(patient);
                        }

                        Console.WriteLine($"\n{patients.Dequeue()} is now in the cabinet\n");

                        foreach (var patient in patients)
                        {
                            Console.WriteLine($"{patient} is still waiting");
                        }

                        Console.WriteLine($"\nThe next in line is {patients.Peek()} \n");

                        Queue<int> count = new Queue<int>();
                        count.Enqueue(1);
                        count.Enqueue(2);
                        count.Enqueue(3);
                        count.Enqueue(4);

                        LearningFunctions.QueueOrStackToConsole(count);*/

            //LIFO, Stack
            /*            Stack<int> numbers = new Stack<int>();
                        numbers.Push(1); // last to console.write
                        numbers.Push(2);
                        numbers.Push(3);
                        numbers.Push(4);
                        numbers.Push(5); // first to console.write
                        LearningFunctions.QueueOrStackToConsole(numbers);
                        Console.WriteLine(numbers.Peek());
                        Console.WriteLine(numbers.Pop());*/

            // Dictionary
            /*            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
                        countriesCapitals.Add("RU", "Moscow");
                        countriesCapitals.Add("UA", "Kiev");
                        countriesCapitals.Add("BY", "Minsk");

                        if (countriesCapitals.ContainsKey("RU"))
                        {
                            Console.WriteLine(countriesCapitals["RU"]);
                        }

                        foreach (var capital in countriesCapitals)
                        {
                            Console.WriteLine($"{capital.Value} is the capital of {capital.Key}");
                        }*/

            // OOP
            /*            Car ferrari = new Car("F40", 200, 20);
                        ferrari.ShowTechnicalPassword();

                        Car ford = new Car();
                        ford.ShowTechnicalPassword();

                        Car lada = new Car("kalina", -10, 30);
                        lada.ShowTechnicalPassword();

                        Car[] cars = { new Car("renault", 110, 3), new Car("tayota", 400, 5) };
                        foreach (var car in cars)
                        {
                            car.ShowTechnicalPassword();
                        }*/

            // OOP has-a
            /*            Performer worker1 = new Performer("Nik");
                        Performer worker2 = new Performer("John");

                        Task[] tasks = { new Task(worker1, "Build house"), new Task(worker2, "Buy groceries") };

                        Board schedule = new Board(tasks);
                        schedule.ShowAllTasks();*/

            // OOP is-a
            Knight warrior1 = new Knight(120, 30, 40);
            Barbarian warrior2 = new Barbarian(100, 20, 30, 2);

            warrior1.TakeDamage(80);
            warrior2.TakeDamage(80);

            Console.Write("Knight:");
            warrior1.ShowInfo();
            Console.Write("Barbarian:");
            warrior2.ShowInfo();
        }
    }
    class LearningFunctions
    {
        public static void WriteError(string text, ConsoleColor color = ConsoleColor.Green)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = defaultColor;
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static void AddWithOut(out int sum, int x, int y)
        {
            sum = x + y;
        }
        public static void AddWithRef(ref int sum, int x, int y)
        {
            sum = x + y;
        }
        public static void EdditArray(int[] array, int index, int value)
        {
            array[index] = value;
        }
        public static int[] EdditArrayWithModification(int[] array, int index, int value)
        {
            array = new int[6];
            array[index] = value;
            return array;
        }
        public static int[] ResizeArr(int[] array, int size)
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
        public static int[,] ResizeArr(int[,] array, int x, int y)
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
        public static void ShowSquares(int val)
        {
            Console.WriteLine("{0:f} squared = {1:d}", val, val * val);
        }
        public static void QueueOrStackToConsole(Stack<int> arr)
        {
            foreach (var number in arr)
            {
                if (arr.ElementAt(number - 1) == arr.Count)
                {
                    Console.Write(number + "\n");
                }
                else
                {
                    Console.Write(number + ", ");
                }

            }
        }
        public static void QueueOrStackToConsole(Queue<int> arr)
        {
            foreach (var number in arr)
            {
                if (arr.ElementAt(number - 1) == arr.Count)
                {
                    Console.Write(number + "\n");
                }
                else
                {
                    Console.Write(number + ", ");
                }

            }
        }
    }
    class Car
    {
        public string Name = "unspecified"; // public uses "Name"
        public int MaxHorsepower;
        public int Age;

        private int _horsepower = 100; // private uses "_name"

        public Car(string name, int maxHorsepower, int age)
        {
            if (maxHorsepower < 0)
            {
                MaxHorsepower = 1;
            }
            else
            {
                MaxHorsepower = maxHorsepower;
            }
            Name = name;
            Age = age;
        }

        public Car()
        { }


        public void ShowTechnicalPassword()
        {
            Console.WriteLine($"This {Name} has {_horsepower} default power, {MaxHorsepower} max power, age {Age}\n");
        }

    }
    class Performer
    {
        public string Name;
        public Performer(string name)
        {
            Name = name;
        }
    }
    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }
    class Task
    {
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}\n");
        }
    }
    class Warrior
    {
        protected int Health;
        protected int Armor;
        protected int Damage;

        public Warrior(int health, int armor, int damage)
        { 
            Health= health;
            Armor= armor;
            Damage= damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
    }
    class Knight : Warrior
    {
        public Knight(int health, int armor, int damage ): base(health, armor, damage )
        { 
            
        }
        public void Pray()
        {
            Armor += 2;
        }

    }
    class Barbarian: Warrior
    {
        public int AttackSpeed;
        public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed) 
        {
            AttackSpeed= attackSpeed;
        }
        public void Shout()
        {
            Armor -= 2;
            Health += 10;
        }
    }
}
