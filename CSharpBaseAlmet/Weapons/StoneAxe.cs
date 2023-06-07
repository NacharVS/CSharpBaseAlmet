using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpBaseAlmet.Weapons
{
    internal class StoneAxe : Weapon
    {
        public StoneAxe() : base(7, 30)
        {
        }

        public override (int, bool, string) Hit()
        {
            if (new Random().Next(1, 101) < 31)
            {
                Console.WriteLine("OpenWound!");
                return (Damage, true, "StoneAxe");
            }
            else
            {
                return (Damage, true, "StoneAxe");
            }
        }
    }


}
