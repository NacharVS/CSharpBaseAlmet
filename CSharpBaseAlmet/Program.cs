Console.WriteLine("Start");

int[] arrayOne = new int[12];

int buffer = 0;
int checks = 0;
Random random = new Random();

for (int i = 0; i < arrayOne.Length; i++)
{
    arrayOne[i] = random.Next(10, 100);
    Console.Write(arrayOne[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < arrayOne.Length; i++)
{
    for (int j = 0; j < arrayOne.Length - 1 - i; j++)
    {
        if(arrayOne[j] > arrayOne[j + 1])
        {
            buffer = arrayOne[j];
            arrayOne[j] = arrayOne[j + 1];
            arrayOne[j + 1] = buffer;
        }
        checks++;
    }
    Console.WriteLine();
    foreach (var item in arrayOne)
    {
        Console.Write(" " + item);
    }
}
Console.WriteLine();
Console.WriteLine("Sorted:");
foreach (var item in arrayOne)
{
    Console.Write(" " + item);
}
Console.WriteLine();
Console.WriteLine(checks);

