namespace WorkingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            Console.WriteLine($"{city} is {city.Length} characters long.");

            Console.WriteLine($"First char is {city[0]} and fourth char is {city[3]}.");

            string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
            string[] citiesArray = cities.Split(',');
            Console.WriteLine($"There are {citiesArray.Length} items in the array.");
            foreach(string element in citiesArray)
            {
                Console.WriteLine(element);
            }

            string fullName = "Alan Shore";
            int indexOfTheSpace = fullName.IndexOf(" ");
            string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace);
            string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);
            Console.WriteLine($"Original: {fullName}");
            Console.WriteLine($"Swapped: {lastName}, {firstName}");

        }
    }
}
