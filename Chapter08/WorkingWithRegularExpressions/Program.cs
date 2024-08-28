using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine()!;

            Regex ageChecker = new(@"^\d+$");
            if (ageChecker.IsMatch(input))
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine($"Valid age not entered: {input}");
            }

            string films = """
                "Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
                """;
            Console.WriteLine($"Films to split: {films}");
            string[] filmsDumb = films.Split(',');
            Console.WriteLine("Split with String.Split() method:");
            foreach ( string film in filmsDumb )
            {
                Console.WriteLine(film);
            }

            Regex csv = new("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            MatchCollection filmsSmart = csv.Matches(films);
            Console.WriteLine("Splitting with Regex:");
            foreach(Match film in filmsSmart)
            {
                Console.WriteLine(film.Groups[2].Value);
            }
        }
    }
}
