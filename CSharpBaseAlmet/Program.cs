using CSharpBaseAlmet;
//Дана матрица заполненная рандомными значениями.
//Необходимо отсортировать номера строк в порядке
//возрасстания суммы в строке

int[,] array = new int[10, 10];
NumSum[] nums = new NumSum[10];
Random random = new Random();
NumSum buffer = new NumSum();

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new NumSum();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    nums[i].Number = i + 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write($"{array[i, j]} ");
        nums[i].Sum += array[i, j];

    }

    Console.WriteLine();
}

Console.WriteLine();

foreach (var item in nums)
{
    Console.WriteLine($"{item.Number} - {item.Sum}");
}

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length - 1 - i; j++)
    {
        if (nums[j].Sum > nums[j + 1].Sum)
        {
            //bufSum = nums[j].Sum;
            //bufNum = nums[j].Number;
            //nums[j].Sum = nums[j + 1].Sum;
            //nums[j].Number = nums[j + 1].Number;
            //nums[j + 1].Sum = bufSum;
            //nums[j + 1].Number = bufNum;
            buffer = nums[j];
            nums[j] = nums[j + 1];
            nums[j + 1] = buffer;

        }

    }
    Console.WriteLine();
}
Console.WriteLine();

foreach (var item in nums)
{
    Console.WriteLine($"{item.Number} - {item.Sum}");
}



















