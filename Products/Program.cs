var products = new (string Name, int Count) []
{
    ("Apple", 1200),
    ("Banana", 35000),
    ("Orange", 560),
    ("Mango", 7800),
    ("Peach", 45)
};

Console.WriteLine("{0, -8} {1, 6}", "Name", "Count");

foreach (var (Name, Count) in products)
{
    Console.WriteLine("{0, -8} {1, 6:N0}", Name, Count);
}