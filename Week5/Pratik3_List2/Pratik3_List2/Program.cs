List<string> coffee = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Kahve {i + 1}:");
    string userInput = Console.ReadLine();
    coffee.Add(userInput);
}

foreach (var item in coffee)
{
    Console.WriteLine(item);
}