using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class Healer : Unit
    {
        public int HealingResource { get; set; }
        public Healer(string type, int health, int speed, int healingResource) : base(type, health, speed)
        {
            HealingResource = healingResource;
        }

        public Healer() : base("Medic", 45, 8)
        {
            HealingResource = 10;
        }

        public void HealSomebody(Unit unit)
        {
            if (HealingResource > 0)
            {
                while (unit.Health < unit.MaxHealth)
                {
                    unit.Health += 2;
                    HealingResource--;
                }
            }
            else
            {
                Console.WriteLine("No resource");
            }
        }

        public void ShowReource()
        {
            Console.WriteLine(HealingResource);
        }
    }
}
