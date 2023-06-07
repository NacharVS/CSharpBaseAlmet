using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class Blacksmith : Unit
    {
        public Blacksmith() : base("Blacksmith", 30, 5)
        {
            
        }

        public void Repair(Weapon weapon)
        {
            weapon.Durability
        }
    }
}
