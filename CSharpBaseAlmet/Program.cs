Console.WriteLine("Start");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(a > b && a > c && c > b)   // & && | ||
{
    Console.WriteLine(a);
}
else
{
    if (b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}

Console.WriteLine("End");

