using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Tower
{
    internal interface IWatchingTower
    {
        public int WallDurability { get; set; }
        public string Material { get; set; }

        public void ShowInfo();
    }
}
