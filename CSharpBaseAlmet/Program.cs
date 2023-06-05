
//int a = 453;
//int b = a / 100;
//int d = a % 10;
//int c = a % 100 / 10;



//Console.WriteLine(b + d + c);

Console.WriteLine("Start");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b && a > c && c < b)
{
    Console.WriteLine(a);
} else
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




//Console.WriteLine("Start");

//int num = int.Parse(Console.ReadLine());
////int b = int.Parse(Console.ReadLine());
////int c = int.Parse(Console.ReadLine());
////int a = int.Parse(Console.ReadLine());

//if (num > 99 && num < 1000)
//{
//    int a = num / 100;
//    int b = num % 10;
//    int c = num % 100 / 10;
//    if (num % 1 == 0)
//    {
//        Console.WriteLine(a + b + c);
//    }
//    else
//    {
//        Console.WriteLine(b * a * c);
//    }
//    Console.WriteLine("Correctid");
//}
//else
//{
//    Console.WriteLine("Num Incorrect");
//}


//Console.WriteLine("End");

////string v = Console.ReadLine();

////int x = int.Parse(Console.ReadLine());
////Console.WriteLine("Написали текст:" + v);

//Console.WriteLine("Start");

//int num = int.Parse(Console.ReadLine());
////int b = int.Parse(Console.ReadLine());
////int c = int.Parse(Console.ReadLine());

//if (num > 99 && num < 1000)
//{
//     b = num / 100;
//     d = num % 10;
//     c = num % 100 / 10;
//    if (num % 2 == 0)
//    {
//        Console.WriteLine(b + d + c);
//    }
//    else
//    {
//        Console.WriteLine(b * d * c);
//    }

//}
//else
//{
//    Console.WriteLine("Num Incorrect");
//}



//Console.WriteLine("End");

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//long res = 1;


//for (int i = a; i <= b; i++)
//{
//    if (i % 7 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    //res = res * a;
//}

//Console.WriteLine(res);

// ---------------------------------------------------------

//for (int i = 1; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i * j}");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine("end");


//-----------------------------------------------------------------

//Console.WriteLine("Start");

//Console.Write("Введите требуемое количество: ");
//int kol = int.Parse(Console.ReadLine());

//for (int i = 0; i < 10; i++)
//{
//    for (int j = i + 1; j < 10; j++)
//    {
//        for (int k = j + 1; k < 10; k++)
//        {
//            if ((i + j + k) == kol)
//                Console.WriteLine($"{i} + {j} + {k} = {i + j + k}");
//        }
//    }
//}

//Console.WriteLine("End");

// -------------------------------------------------------------------
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("-----");
//int[] numbers = new int[x];
//int max = 0;
//int index = 0;

//Random random = new Random();

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(10, 100);
//}

//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("-----");

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//        index = i + 1;
//    }
//}

//Console.WriteLine(max);
//Console.WriteLine("-----");
//Console.WriteLine(index);
//Console.ReadLine();
//Console.WriteLine("End");
// ----------------------------------------------------------------------

//Console.WriteLine("Start");

//Console.Write("Start : ");
//int x = int.Parse(Console.ReadLine());
//int[] numbers = new int[x]; //length = x, maxIndex = length - 1 = x - 1

//Random random = new Random();

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(10, 100);
//}

//Console.WriteLine("Generation complete");

//for (int i = 0; i < numbers.Length; i++)
//{

//    Console.Write($"{numbers[i]}; ");
//    //numbers[i] = random.Next(10, 100);
//}

//Console.WriteLine();

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > numbers[i - 1])
//        Console.Write($"{numbers[i]}; ");
//    //numbers[i] = random.Next(10, 100);
//}

//Console.WriteLine();

//Console.WriteLine("End");
//-------------------------------------------------------------

