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

        public override (int, bool) Hit()
        {
            if (new Random().Next(1, 101) < 20)
            {
                Console.WriteLine("Stun!");
                return (Damage, true);
            }
            else
            {
                return (Damage, false);
            }
        }
    }
}
