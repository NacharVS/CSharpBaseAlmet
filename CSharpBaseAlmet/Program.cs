using CSharpBaseAlmet;

List<Unit> unitList = new List<Unit>();
Random random = new Random();
Unit unitBuffer;

for (int i = 0; i < 10; i++)
{
    unitBuffer = new Unit("Worker", random.Next(30, 91), 
        random.Next(9, 19), random.Next(0, 8));
    unitList.Add(unitBuffer);
}

foreach (var item in unitList)
{
    Console.WriteLine($"{item.Type} - {item.Health} - {item.Speed} - {item.Defense}");
}
Console.WriteLine();
foreach (var item in unitList)
{
    if(item.Health > 60 && item.Speed > 12)
    {
        Console.WriteLine($"{item.Type} - {item.Health} - {item.Speed} - {item.Defense}");
    }
}














