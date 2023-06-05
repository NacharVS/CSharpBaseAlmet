Console.WriteLine("Start");
//int x = int.Parse(Console.ReadLine());
int[] arrayOne = new int[12]; //length = 10 maxIndex = length - 1;
int[] arrayTwo = new int[6];
Random random = new Random();

for (int i = 0; i < arrayOne.Length; i++)
{
    arrayOne[i] = random.Next(10, 100);
    Console.Write(arrayOne[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < arrayTwo.Length; i++)
{
    arrayTwo[i] = random.Next(10, 100);
    Console.Write(arrayTwo[i] + " ");
}
Console.WriteLine();

if(arrayOne.Length > arrayTwo.Length)
{
    for (int i = 0; i < arrayTwo.Length; i++)
    {
        arrayOne[i] = arrayOne[i] + arrayTwo[i];
    }
    foreach (var item in arrayOne)
    {
        Console.Write(item + " ");
    }
}
else
{
    for (int i = 0; i < arrayOne.Length; i++)
    {
        arrayTwo[i] = arrayOne[i] + arrayTwo[i];       
    }
    foreach (var item in arrayTwo)
    {
        Console.Write(item + " ");
    }
}










// 0 1 1 2 3 5 8 13 21 34 ....
Console.WriteLine();
Console.WriteLine("End");

