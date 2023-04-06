int x = int.MaxValue - 1;
WriteLine($"Initial value: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");
x++;
WriteLine($"After incrementing: {x}");

WriteLine("Before checked block");
checked
{
    try
    {
        x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
    catch (OverflowException) 
    {
        WriteLine("The code overflowed but exception was caught.");
    }

}

//int y = int.MaxValue + 1; //compile error

unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}