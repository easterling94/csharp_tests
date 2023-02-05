using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int percentConverter = 100;
            float health;
            float armor;
            float damage;

            Console.Write("Input HP points: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Armor points: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Damage points: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= damage * armor / percentConverter;
            Console.WriteLine($"You've got hitten by {damage} power, you have {health} points left");
        }
    }
}
