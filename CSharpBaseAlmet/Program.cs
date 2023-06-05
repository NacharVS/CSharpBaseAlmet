Console.WriteLine("Start");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
long res = 1;

for (int i = 0; i < b; i++)
{
    res = res * a;
}

Console.WriteLine(res);
Console.WriteLine("End");

