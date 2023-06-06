




static void ShowBinaryArray()
{   
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,2);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[,] GetBinaryArray()
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 2);            
        }
    }
    return array;
}

static void ShowCustomArray(string name, int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    Console.WriteLine($"Array '{name}' ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static void ArrayGenegation(int[] numbers, int min, int max)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max);
        Console.Write(numbers[i] + " ");
    }
}

static void Summ(params double[] ints)
{
    int sum = 0;
    foreach (int i in ints)
    {
        sum += i;
    }
    Console.WriteLine(sum);
}

static void ShowInConsole(string s)
{
    Console.WriteLine(s);
}




