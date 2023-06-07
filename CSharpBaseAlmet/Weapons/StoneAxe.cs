using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class StoneAxe : Weapon
    {
        public StoneAxe() : base(7, 30)
        {
        }

        public override (int, bool, string) Hit()
        {
            if (new Random().Next(1, 101) <= 30)
            {
                Console.WriteLine($"Bleeding!");
                return (Damage+2, true, "StoneAxe");

            }
            else
            {
                return (Damage, false, "StoneAxe");
            }
        }
    }
}
