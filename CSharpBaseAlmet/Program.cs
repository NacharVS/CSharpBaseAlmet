Console.WriteLine("Start");

int[,] array = new int[5,5];
int max = 0;
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write($"{array[i, j]} ");

        if(array[i, j] > max)
        {
            max = array[i, j];
        }
    }
    Console.Write($"Max in {i+1} : {max}");
    max = 0;
    Console.WriteLine();
}





