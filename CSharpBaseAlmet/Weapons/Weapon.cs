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
        private int _durabiblty;
        private int _maxDurability;
        public Weapon(int damage, int durability)
        {
            _damage = damage;
            _durabiblty = durability;
            _maxDurability = durability;
        }

       
        
        public virtual int Damage 
        {
            get 
            {
                return _damage;
            }
            set => _damage = value; 
        }

        public int Durabiblty 
        {
            get
            {
                return _durabiblty;
            }
            set
            {
                if(value >= _maxDurability)
                {
                    _durabiblty = _maxDurability;
                    return;
                }
                _durabiblty = value;
            }
        }

        public virtual (int, bool, string) Hit()
        {  
                return (Damage, false, String.Empty);
        }
    }
}
