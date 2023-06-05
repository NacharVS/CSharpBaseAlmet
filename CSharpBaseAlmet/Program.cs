Console.WriteLine("Start");

int a = int.Parse(Console.ReadLine());

int sot = 0;
int des = 0;
int ed = 0;


if (a > 99 && a < 1000)
{

    ed = a % 10;
    sot = a / 100;
    des = a % 100 / 10;

    if (a % 2 == 0)
    {
        Console.WriteLine($"Число четное. Сумма - {ed + sot + des} пам-пам");
    }
    else
    {
        Console.WriteLine($"Число нечетное. Произведение - {ed * sot * des} пам-пам");
    }
}
else
{
    Console.WriteLine("Number incorrect");
}



Console.WriteLine("End");

