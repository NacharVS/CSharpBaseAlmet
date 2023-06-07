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
        public Weapon(int damage, int durability)
        {
            Damage = damage;
            Durability = durability;
        }

       
        public int Durability { get; set; }
        public virtual int Damage 
        {
            get 
            {
                return _damage;
            }
            set => _damage = value; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"durability - {Durability}");
        }
    }
}
