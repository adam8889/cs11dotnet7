Console.WriteLine("-------------------------------------------------------------------------------");
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "Type", "Byte(s) of memory", "Min", "Max");
Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "short", sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "int", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "long", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "float", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "double", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine("{0, -10}{1, -20}{2, 25}{3, 24}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);