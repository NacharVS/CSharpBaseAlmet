using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet.Tower
{
    internal class Barracks : IBarracks
    {
        private int _damage;
        private List<string> _garriosn;

        public int Damage 
        {
            get => _damage; 
            set => _damage = Damage; 
        }
        public List<string> Garrison 
        { 
            get => _garriosn; 
            set => _garriosn = Garrison; 
        }

        public void AddGarrison(string garrison)
        {
            _garriosn.Add(garrison);
        }
        public Barracks() 
        {
            _damage = 100;
            _garriosn = new List<string>()
            {
                "Player 1",
                "Player 2"
            };
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Barracks. Damage - {_damage}. Garrison:");
            foreach (string item in _garriosn) 
            {
                Console.WriteLine( item );
            }
        }
    }
}
