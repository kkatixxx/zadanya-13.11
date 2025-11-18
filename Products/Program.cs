var products = new (string Name, int Count) []
{
    ("Milk", 30),
    ("Bread", 20),
    ("Sugar", 5000),
    ("Orange", 250),
    ("Pistol", 1)
};

Console.WriteLine("{0, -8} {1, 6}", "Name", "Count");

foreach (var (Name, Count) in products)
{
    Console.WriteLine("{0, -8} {1, 6:N0}", Name, Count);
}