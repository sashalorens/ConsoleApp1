namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputProvider provider = new UserInputProvider();
            // block 1
            Console.WriteLine("Sum of two numbers");
            int[] addends = provider.getUserInput(2);
            int sum = addends[0] + addends[1];

            Console.WriteLine($"{addends[0]} + {addends[1]} = {sum}");

            Console.WriteLine("\nDivision of two numbers");
            int[] divisionNumbers = provider.getUserInput(2);
            int quotient = divisionNumbers[0] / divisionNumbers[1];
            Console.WriteLine($"{divisionNumbers[0]} / {divisionNumbers[1]} = {quotient}");

            Console.WriteLine("\nResult of the specified operations");
            int res1 = -1 + 4 * 6;
            int res2 = (35 + 5) % 7;
            // Using int here because the given values are integers; therefore, according to
            // Microsoft docs, the result is rounded towards zero
            int res3 = 14 + -4 * 6 / 11;
            int res4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"-1 + 4 * 6 = {res1}");
            Console.WriteLine($"(35 + 5) % 7 = {res2}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {res3}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {res4}");


            // block 2
            Console.WriteLine("\nSwapping two numbers");
            int[] numbers = provider.getUserInput(2);
            int num1 = numbers[0];
            int num2 = numbers[1];
            int temp;
            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");



            // block 3
            Console.WriteLine("\nRequesting 3 numbers to nultiply");
            int[] factors = provider.getUserInput(3);
            int product = factors[0] * factors[1] * factors[2];
            Console.WriteLine($"{factors[0]} * {factors[1]} * {factors[2]} = {product}");
        }
    }
}