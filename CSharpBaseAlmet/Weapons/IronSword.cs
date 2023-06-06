using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class IronSword : Weapon
    {
        public IronSword() : base(6, 40)
        {
        }

        public override int Damage 
        {
            get 
            {
                Console.WriteLine("DoubleDamage");
                return base.Damage;
                
            }
            set => base.Damage = value; 
        }
    }
}
