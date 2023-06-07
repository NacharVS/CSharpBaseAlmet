using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Buildings
{
    interface IBarrack
    {
        public int WallDurability { get; set; }

        public string Material { get; set; }

        public void ShowInfo();
    }
}
