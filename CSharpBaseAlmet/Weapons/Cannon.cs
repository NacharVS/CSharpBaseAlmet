using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal class Cannon : IRangeWeapon
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

        public Cannon()
        {
            _arrowsCount = 5;
            _range = 50;
            _rangeDamage = 100;
        }

        public void Shoot()
        {
            Console.WriteLine("Bum-bum!");
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
