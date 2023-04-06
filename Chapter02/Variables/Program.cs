using System.Xml;

object height = 1.88; //storing a double in an object
object name = "Adam"; //storing a string in an object
Console.WriteLine($"{name} is {height} meters tall");

//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

// storing a string in a dynamic object
// string has a Length property
dynamic something = "Ahmed";
// int does not have a Length property
//something = 12;
// an array of any type has a Length property
 something = new[] { 3, 5, 7 };

// this compiles but would throw an exception at run-time
// if you later stored a data type that does not have a property named Length
Console.WriteLine($"Length is {something.Length}");

var population = 67_000_000; // 67 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // Booleans have value of true or false


Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");

number = default;
Console.WriteLine($"number has been reset to its default: {number}");