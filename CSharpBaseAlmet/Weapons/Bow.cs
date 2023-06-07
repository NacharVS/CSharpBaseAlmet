using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class Bow : IRangeWeapon
    {
        private int _rangeDamage;
        private int _range;
        public int RangeDamage 
        { 
            get => _rangeDamage; 
            set => _rangeDamage = RangeDamage; 
        }
        public int Range 
        {
            get => _range;
            set => _range = Range;
        }

        private int _arrowsCount;

        public Bow()
        {
            _arrowsCount = 10;
            _rangeDamage = 20;
            _range = 30;
        }

        public void Shoot()
        {
            Console.WriteLine("piu-piu!");
            DecreaseCount();
        }

        private void DecreaseCount()
        {
            _arrowsCount--;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"arrows - {_arrowsCount} damage - {_rangeDamage} range - {_range}");
        }
    }
}
