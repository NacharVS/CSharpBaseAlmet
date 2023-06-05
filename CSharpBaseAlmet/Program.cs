

int a = int.Parse(Console.ReadLine());

int sot = 0;
int des = 0;
int ed = 0;

ed = a % 10;
sot = a / 100;
des = a % 100 / 10;


Console.WriteLine(ed + sot + des);

