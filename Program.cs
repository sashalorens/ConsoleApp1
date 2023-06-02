namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputProvider inputProvider = new UserInputProvider();
            NumberComparison comparison = new NumberComparison();
            // part 1
            Console.WriteLine("Finding the largest value of three integers");
            int[] numbers1 = inputProvider.getUserInput(3);
            int max = comparison.FindMax(numbers1[0], numbers1[1], numbers1[2]);
            Console.WriteLine($"The largest number is {max}");

            // part 2
            Console.WriteLine("\nFinding the smallest value of three integers");
            int[] numbers2 = inputProvider.getUserInput(3);
            int min = comparison.FindMin(numbers2[0], numbers2[1], numbers2[2]);
            Console.WriteLine($"The smallest number is {min}");

            // part 3
            Console.WriteLine("\nFinding the nearest value of two integers");
            const int target = 20;
            int[] numbers3 = inputProvider.getUserInput(2);
            int nearest = comparison.FindNearest(target, numbers3[0], numbers3[1]);
            Console.WriteLine($"The nearest to {target} number is {nearest}");

            // part 4
            Console.WriteLine("\nFinding the sum of values in an array");
            int[] addends = inputProvider.getUserInput(5);
            int sum = comparison.GetSumOfArray(addends);
            Console.WriteLine($"Sum of the values equals {sum}");

            // part 5
            Console.WriteLine("Finding the largest value in an array");
            int[] numbers4 = inputProvider.getUserInput(5);
            int maxOfArray = comparison.GetMaxInArray(numbers4);
            Console.WriteLine($"The largest number in an array is {maxOfArray}");
        }
    }
}