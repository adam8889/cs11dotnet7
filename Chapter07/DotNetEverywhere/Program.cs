Console.WriteLine("I can run everywhere!");
Console.WriteLine($"OS version is: {Environment.OSVersion}");

if (OperatingSystem.IsMacOS())
{
    Console.WriteLine("I am macOS.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10, build: 22000))
{
    Console.WriteLine("I am Windows 11.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    Console.WriteLine("I am Windows 10.");
}
else
{
    Console.WriteLine("I am some other mysterious OS.");
}
