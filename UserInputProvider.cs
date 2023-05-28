using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UserInputProvider
    {
        public int[] getUserInput(int amount)
        {
            List<int> numbers = new List<int>();
            string[] suffixes = { "st", "nd", "rd", "th" };

            for (int i = 0; i < amount; i++)
            {
                int temp;

                do
                {
                    int suffixIndex = Math.Min(i, suffixes.Length - 1);
                    string description = amount == 1 ? "your" : $"{i + 1}{suffixes[suffixIndex]}";
                    Console.WriteLine($"Please enter the {description} number");
                } while (!int.TryParse(Console.ReadLine(), out temp));
                numbers.Add(temp);

            }
            return numbers.ToArray();
        }
    }
}
