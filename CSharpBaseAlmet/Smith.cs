using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class Smith : Unit
    {
        public Smith(string type, int health, int speed) : base(type, health, speed)
        {
        }
        public int RepairResource { get; set; } = 1;

        public void RepairSomebody(BattleUnit unit)
        {
            if (RepairResource > 0)
            {
                unit.CurrentWeapon.Durabiblty += 10;
                Console.WriteLine($"{unit.CurrentWeapon.GetType().Name} fix. Durability = {unit.CurrentWeapon.Durabiblty}");
                RepairResource--;
            }
            else
            {
                Console.WriteLine("No resource");
            }
        }

        public void ShowReource()
        {
            Console.WriteLine(RepairResource);
        }
    }
}
