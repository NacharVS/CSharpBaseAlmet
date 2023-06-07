using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Buildings
{
    internal class WatchingTower : IWatchingTower
    {
        private int _damage;
        private string _listGarrison;
        public int Damage 
        { 
            get => _damage; 
            set => Damage = _damage; 
        }
        public string ListGarrison 
        { 
            get => _listGarrison; 
            set => ListGarrison = _listGarrison; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"damage - {_damage} listgarrison - {_listGarrison}");
        }
    }
}
}
