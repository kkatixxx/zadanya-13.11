Console.Write("Введите количество яиц: ");
string input = Console.ReadLine();

try
{
    int eggs = int.Parse(input);
    Console.WriteLine($"Вы ввели {eggs} яиц.");
}
catch
{
    Console.WriteLine("Ошибка при int.Parse()"); 
}

if (int.TryParse(input, out int eggsTry))
{
    Console.WriteLine($"(TryParse) Вы ввели {eggsTry} яиц.");
}
else
{
    Console.WriteLine("(TryParse) Ввод некорректен.");
}
