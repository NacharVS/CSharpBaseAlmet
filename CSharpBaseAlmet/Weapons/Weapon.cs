using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpBaseAlmet.Unit;

namespace CSharpBaseAlmet.Weapons
{
    internal class Weapon
    {
        public delegate void DurabilityChangedDelegate();
        private int _damage;
        private int _durability;
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
                if (_durability < 0)
                {
                    _durability = 0;
                    Console.WriteLine("Weapon is broken");
                }
                else
                {
                    _durability = value;
                }
                DurabilityChangedEvent?.Invoke();
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

        public virtual (int,bool, string) Hit()
        {
            return (Damage, false, "BronzeMace");
        }

        public void ShowDurability()
        {
            Console.WriteLine($"durability - {_durability}");
        }

        public event DurabilityChangedDelegate DurabilityChangedEvent;
    }
}
