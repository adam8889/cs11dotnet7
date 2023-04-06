for (int i = 1; i <= 100; i++)
{
    bool divisible = false;
    string str = "";
    if(i % 3 == 0)
    {
        divisible = true;
        str = str + "Fizz";
    }

    if(i % 5 == 0)
    {
        divisible = true;
        str = str + "Buzz";
    }

    if (divisible)
    {
        Console.WriteLine(str);
    }
    else
    {
        Console.WriteLine(i);
    }
}