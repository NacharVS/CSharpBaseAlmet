using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class IronSword : Weapon
    {
        // 30% - шанс двойного урона
        public IronSword() : base(6, 40)
        {
        }

        public override int Damage 
        {
            get 
            {
                if (new Random().Next(0,11) < 4)
                {
                    Console.WriteLine($"DoubleDamage {base.Damage * 2}");

                    return base.Damage * 2;
                }
                else
                {
                    Console.WriteLine(base.Damage);
                    return base.Damage;
                }
                
            }
            set => base.Damage = value; 
        }
    }
}
