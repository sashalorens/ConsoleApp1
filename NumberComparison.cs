using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NumberComparison
    {
        // part 1; reuses part 5
        // I expect this method to have arity of 3 because the task is about
        // taking three separate integers; however, 
        public int FindMax(int num1, int num2, int num3)
        {
            int[] numbers = {num1, num2, num3};
            return GetMaxInArray(numbers);
        }
        // part 2
        public int FindMin(int num1, int num2, int num3)
        {
            int[] numbers = { num1, num2, num3 };
            return numbers.Min();
        }
        // part 3
        public int FindNearest(int target, int num1, int num2)
        {
            if (num1 == num2)
                return 0;
            int diff1 = Math.Abs(num1 - target);
            int diff2 = Math.Abs(num2 - target);

            return diff1 < diff2 ? num1 : num2;
        }
        // part 4
        public int GetSumOfArray(int[] numbers)
        {
            return numbers.Sum();
        }
        // part 5
        public int GetMaxInArray(int[] numbers)
        {
            return numbers.Max();
        }
    }
}
