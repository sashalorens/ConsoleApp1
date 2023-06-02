using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NumberController
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

        // advanced HW, part 1
        public int ReverseNumber(int number)
        {
            string str = number.ToString();
            string acc = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                acc += str[i];
            }
            return int.Parse(acc);
        }

        // advanced HW, part 3
        public int GetSecondMaxInArray(int[] numbers)
        {
            // or just sort an array and take by index
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }

                else if (num > secondMax)
                {
                    secondMax = num;
                }
            }
            return secondMax;
        }

        // advanced HW, part 4
        // it would be funnier with sides given, not angles
        public bool IsTriangleValid(int[] angles)
        {
            int sum = 0;
            const int validSum = 180;
            foreach(int angle in angles)
            {
                if (angle == 0)
                {
                    return false;
                }
                sum += angle;
            }
            return sum == validSum;
        }
    }
}
