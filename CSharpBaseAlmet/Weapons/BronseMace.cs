using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpBaseAlmet.Weapons
{
    internal class BronseMace : Weapon
    {
        public BronseMace() : base(12, 40)
        {
        }

        public override (int, bool, string) Hit()
        {
            if (new Random().Next(1, 101) < 20)
            {
                Console.WriteLine("Stun!");
                return (Damage, true, "BronzeMace");
            }
            else
            {
                return (Damage, true, "BronzeMace");
            }
        }
    }
}
