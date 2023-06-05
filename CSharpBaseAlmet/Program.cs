Console.WriteLine("Start");
int x = int.Parse(Console.ReadLine());
int[] numbers = new int[x]; //length = 10 maxIndex = length - 1;

Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-5, 5);
}

Console.WriteLine("Generation complete");

foreach (int item in numbers)
{
    if (item == 0)
        break;
    Console.WriteLine(item);
}


// 0 1 1 2 3 5 8 13 21 34 ....
Console.WriteLine();
Console.WriteLine("End");

