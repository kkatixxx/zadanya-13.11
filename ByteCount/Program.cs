using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("sbyte: size = {0}, min = {1}, max = {2}",
            sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);

        Console.WriteLine("byte: size = {0}, min = {1}, max = {2}",
            sizeof(byte), byte.MinValue, byte.MaxValue);

        Console.WriteLine("short: size = {0}, min = {1}, max = {2}",
            sizeof(short), short.MinValue, short.MaxValue);

        Console.WriteLine("ushort: size = {0}, min = {1}, max = {2}",
            sizeof(ushort), ushort.MinValue, ushort.MaxValue);

        Console.WriteLine("int: size = {0}, min = {1}, max = {2}",
            sizeof(int), int.MinValue, int.MaxValue);

        Console.WriteLine("uint: size = {0}, min = {1}, max = {2}",
            sizeof(uint), uint.MinValue, uint.MaxValue);

        Console.WriteLine("long: size = {0}, min = {1}, max = {2}",
            sizeof(long), long.MinValue, long.MaxValue);

        Console.WriteLine("ulong: size = {0}, min = {1}, max = {2}",
            sizeof(ulong), ulong.MinValue, ulong.MaxValue);

        Console.WriteLine("float: size = {0}, min = {1}, max = {2}",
            sizeof(float), float.MinValue, float.MaxValue);

        Console.WriteLine("double: size = {0}, min = {1}, max = {2}",
            sizeof(double), double.MinValue, double.MaxValue);

        Console.WriteLine("decimal: size = {0}, min = {1}, max = {2}",
            sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
}
