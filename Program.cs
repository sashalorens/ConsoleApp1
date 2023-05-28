namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputProvider inputProvider = new UserInputProvider();
            // part 1
            Console.WriteLine("Checking if one of the number is negative and the another one is positive");
            int[] factors = inputProvider.getUserInput(2);
            /*
             * If the requirement is the first number to be negative
             * and the second number to be positive, the implementation looks like this:
             * bool result = factors[0] < 0 && factors[1] > 0;
             * And vice versa, if we want to have the first negative number and the second positive one:
             * bool result = factors[0] > 0 && factors[1] < 0;
             * 
             * However, the acceptance criteria tell only that one of numbers should be
             * positive, and the another one should be negative. 
             */
            bool result1 = (factors[0] * factors[1]) < 0;
            Console.WriteLine($"One of numbers is positive, and the another one is negative: {result1}");

            // part 2
            Console.WriteLine("\nChecking if one of the numbers or their sum equals 20");
            const int required = 20;
            int[] addends = inputProvider.getUserInput(2);
            int sum = addends[0] + addends[1];
            // Don't like the idea to write a loop to iterate over 3 items
            bool result2 = addends[0] == required || addends[1] == required || sum == required;
            Console.WriteLine($"One of numbers or their sum equals 20: {result2}");

            // part 3
            Console.WriteLine("\nDisplaying odd numbers from 1 to 99");
            // Could use i = 0, too; just wanted to avoid an unnecessary iteration
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            // part 4
            Console.WriteLine("\nDisplaying sum of first 500 prime numbers");
            PrimeNumbersController primeController = new PrimeNumbersController();
            int sumOfPrimes = primeController.sumOfNPrimes(500);
            Console.WriteLine($"Sum of first 500 prime numbers equals {sumOfPrimes}");

            // part 5
            Console.WriteLine("\nCalculatng sum of digits of a given number");
            int number = Math.Abs(inputProvider.getUserInput(1)[0]);
            string converted = number.ToString();
            int sumOfDigits = 0;
            for (int i = 0; i < converted.Length; i++)
            {
                int digit = int.Parse(converted[i].ToString());
                sumOfDigits += digit;
            }
            Console.WriteLine($"Sum of digits equals {sumOfDigits}");
        }
    }
}