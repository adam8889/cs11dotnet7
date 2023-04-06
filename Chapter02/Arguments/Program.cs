WriteLine($"There are {args.Length} arguments");

foreach(string arg in args)
{
    WriteLine(arg);
}

if(args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size. e.g. red yellow 50");
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType:  typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true );

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true );

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("the current platform does not support changing the size of the cursor");
}