using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Tower
{
    internal interface IBarracks
    {
        public int Damage { get; set; }
        public List<string> Garrison { get; set; }

        public void ShowInfo();

        public void AddGarrison(string garrison);
    }
}
