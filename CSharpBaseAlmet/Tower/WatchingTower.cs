using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Tower
{
    internal class WatchingTower : IWatchingTower
    {
        private int _wallDuarbility;
        private string _material;
        public int WallDurability 
        {
            get => _wallDuarbility;
            set => _wallDuarbility = WallDurability; 
        }
        public string Material { 
            get => _material; 
            set => _material = Material; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"WatchingTower. Material - {_material}, wallDurability-{_wallDuarbility}");
        }

        public  WatchingTower() 
        {
            _wallDuarbility = 100;
            _material = "Stone";
        }
    }
}
