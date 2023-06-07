using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Buildings
{
    internal interface IWatchingTower
    {
        public int Damage { get; set; }

        public string ListGarrison { get; set; }

        public void ShowInfo();
    }
}
