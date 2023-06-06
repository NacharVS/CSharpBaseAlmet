GetBinaryArray();





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


