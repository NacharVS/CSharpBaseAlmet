using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Weapons
{
    internal interface IRangeWeapon
    {
        public int RangeDamage { get; set; }
        public int Range { get; set; }

        public void Shoot();
        public void ShowInfo();
    }
}
