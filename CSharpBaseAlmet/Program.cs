Console.WriteLine("Start");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if(a < b)
{
    for (int i = a; i <= b; i++)
    {
        if (i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
else
{
    for (int i = a; i >= b; i--)
    {
        if (i % 7 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

// 0 1 1 2 3 5 8 13 21 34 ....
Console.WriteLine();
Console.WriteLine("End");

