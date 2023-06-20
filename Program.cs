namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputProvider provider = new UserInputProvider();
            // Cities by length, then by name
            List<string> cities = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            List<Item> cityItems = cities.Select((x) =>  new Item(x))
                .OrderBy(x => x.Name.Length)
                .ThenBy(x => x.Name)
                .ToList();

            foreach (Item cityItem in cityItems)
            {
                Console.WriteLine(cityItem.Name);
            }

            Console.WriteLine("\n");

            // Food, distinct elements in ascending order
            List<string> food = new List<string> { "Butter", "Honey", "Bread", "Biscuit", "Honey" };
            List<Item> foodItems = food.Select((x) => new Item(x))
                .DistinctBy(x => x.Name)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (Item foodItem in foodItems)
            {
                Console.WriteLine(foodItem.Name);
            }

            Console.WriteLine("\n");

            // Input strings and min length, then find the strings of a specified min length
            const int amount = 3;
            List<string> strings = new List<string>();

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Please enter a string #{i + 1}:");
                var input = Console.ReadLine();
                if (input != null)
                {
                    strings.Add(input);
                }

            }

            int minLength = provider.getUserInput(1)[0];

            List<Item> stringItems = strings.Select(x => new Item(x))
                .Where(x => x.Name.Length >= minLength)
                .ToList();

            foreach (Item stringItem in stringItems)
            {
                Console.WriteLine(stringItem.Name);
            }

        }
    }
}