using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class BronzeMace : Weapon
    {
        public BronzeMace() : base(12, 40)
        {
        }
        public override (int, bool, string, int) Hit()
        {
            if (Durability > 0)
            {
                Durability -= 10;
            }
            else
            {       
                Damage = 2;
            }

            if (new Random().Next(1, 101) < 20)
            {
                Console.WriteLine("Stun!");
                return (Damage, true, "BronzeMace", Durability);
            }
            else
            {
                return (Damage, false, "BronzeMace", Durability);
            }
        }

    }
}
