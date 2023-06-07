using CSharpBaseAlmet.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class Blacksmith : Unit
    {
        public Blacksmith(string type, int health, int speed) : base(type, health, speed)
        {
        }
        public void RepairWeapon(Weapon weapon) 
        {
            weapon.Durability += 10;
        } 
    }
}
