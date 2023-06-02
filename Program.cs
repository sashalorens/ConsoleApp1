using System.Data.Common;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputProvider inputProvider = new UserInputProvider();
            NumberController controller = new NumberController();
            // part 1
            Console.WriteLine("Reversing number");
            int number = inputProvider.getUserInput(1)[0];
            int result = controller.ReverseNumber(number);
            Console.WriteLine(result);

            // part 2
            Console.WriteLine("\nDisplaying alphabet A-like pattern with asterisks");

            for (int y = 0; y <= 7; y++)
            {
                for (int x = 0; x <= 6; x++)
                {
                    bool isPartOfSide = (x == 1 || x == 5) && y != 0;
                    bool isTopOrCenter = (y == 0 || y == 3) && (x > 1 && x < 5);

                    if (isPartOfSide || isTopOrCenter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }


            // part 3
            Console.WriteLine("\nFinding second largest value");
            int[] numbers = inputProvider.getUserInput(5);
            int secondMax = controller.GetSecondMaxInArray(numbers);
            Console.WriteLine(secondMax);

            // part 4
            Console.WriteLine("\nChecking if triangle is valid");
            int[] angles = inputProvider.getUserInput(3);
            bool isValid = controller.IsTriangleValid(angles);
            Console.WriteLine($"Triangle is valid: {isValid}");
        }
    }
}