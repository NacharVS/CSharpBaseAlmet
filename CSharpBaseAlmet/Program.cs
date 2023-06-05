Console.WriteLine("Start");
int x = int.Parse(Console.ReadLine());
int[] numbers = new int[x]; //length = 10 maxIndex = length - 1;
int max = 0;
int index = 0;
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(10, 100);
    Console.Write(numbers[i] + " ");
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
        index = i;
    }
}
Console.WriteLine($"max - {max}, index of max - {index}");




// 0 1 1 2 3 5 8 13 21 34 ....
Console.WriteLine();
Console.WriteLine("End");

