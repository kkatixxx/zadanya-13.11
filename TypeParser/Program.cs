Console.Write("Введите значение: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int intValue))
{
    Console.WriteLine($"Это int: {intValue}");
}
else if (double.TryParse(input, out double doubleValue))
{
    Console.WriteLine($"Это double: {doubleValue}");
}
else if (bool.TryParse(input, out bool boolValue))
{
    Console.WriteLine($"Это bool: {boolValue}");
}
else
{
    Console.WriteLine("Не удалось определить тип.");
}
