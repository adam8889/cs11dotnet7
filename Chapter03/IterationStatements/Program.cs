int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

//string? password;
//int attempts = 0;
//int attemptsAllowed = 10;

//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
//    attempts++;
//    WriteLine($"attempts: {attempts} of {attemptsAllowed}");
//}
//while (password != "Pa$$w0rd" & attempts < attemptsAllowed);

//WriteLine("Correct!");

WriteLine();
for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };

foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}