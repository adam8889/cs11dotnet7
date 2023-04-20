using Packt.Shared;

Person bob = new();
WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtEphesus;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}", arg0: bob.Name, arg1: bob.DateOfBirth);
WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}");
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine($"{bob.Name} has {bob.Children.Count} children.");
foreach(Person child in bob.Children)
{
    WriteLine($"> {child.Name}");
}
WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7)
};

WriteLine($"{alice.Name} was born on {alice.DateOfBirth: dd MMM yy}");

BankAccount.InterestRate = 0.012M; //store a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest");

BankAccount gerrierAccount = new() { AccountName = "Ms. Gerrier", Balance = 98 };
WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest");

Person blankPerson = new();
WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}");

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int frutNumber) = bob.GetNamedFruit();
WriteLine($"Deconstructed: {fruitName}, {frutNumber}");

//deconstructing a person
var (name1, dob1) = bob; //implicetly calls the deconstruct method
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters(number: 52.5, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));

int a = 10;
int b = 20;
int c = 30;

WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");
