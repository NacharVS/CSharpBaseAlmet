using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class NumSum
    {
        public int Number { get; set; }
        public int Sum { get; set; }

        public static void Proc() 
        {
            int[] array = new int[10];
            int q = 0;
            int qq = 10;
            int res;
            try 
            { 
                for (int i = 0; i < 20; i++) 
                {
                    array[i] = q;
                }
                res = qq / q;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Деление на 0");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Out of range array: len = {array.Length}");
            }
            finally
            {
                res = qq / qq;
                Console.WriteLine($"res = {res}");
            }
        }
    }
}
