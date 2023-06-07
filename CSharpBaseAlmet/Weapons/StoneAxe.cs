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

        public override (int, bool, string, int) Hit()
        {
            if (new Random().Next(1, 101) < 31)
            {
                if (Durability > 0)
                {
                    Durability -= 10;
                }
                else
                {
                    Damage = 2;
                }

                Console.WriteLine("Stun!");
                return (Damage, true, "StoneAxe", Durability);
            }
            else
            {
                return (Damage, false, "StoneAxe", Durability);
            }
        }
    }
}
