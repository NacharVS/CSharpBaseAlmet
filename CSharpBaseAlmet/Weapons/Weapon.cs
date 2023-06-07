using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class Weapon
    {
        private int _damage;
        private int _durability;
        public delegate void DurabilityChangedDelegate(int durability);

        public Weapon(int damage, int durability)
        {
            Damage = damage;
            Durability = durability;
        }

        public int Durability
        {
            get
            {
                return _durability;
            }
            set
            {
                if (value <= 0)
                {
                    _durability = 0;
                    Console.WriteLine("Weapon damaged");
                }
                else
                {
                    _durability = value;
                }
                durabilityityChangedEvent?.Invoke(_durability);
            }
        }

        public virtual int Damage 
        {
            get 
            {
                return _damage;
            }
            set => _damage = value; 
        }

        public virtual (int, bool, string, int) Hit() 
        {
            return (Damage, false, String.Empty, Durability);
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Durability-{Durability}");
        }

        public event DurabilityChangedDelegate durabilityityChangedEvent;
    }
}
