using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Buildings
{
    internal class Barrack : IBarrack
    {
        private int _wallDurability;
        private string _material;

        public Barrack()
        {
            _wallDurability = 5;
            _material = "Wood";  
        }

        public int WallDurability 
        { 
            get => _wallDurability; 
            set => WallDurability = _wallDurability; 
        }
        public string Material 
        { 
            get => _material; 
            set => Material = _material; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"walldurability - {_wallDurability} material - {_material}");
        }
    }
}
