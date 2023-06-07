using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class Peasant : Unit
    {        
        public Peasant(string type, int health, int speed) : base(type, health, speed)
        {
        }

        public Peasant() : base("Worker", 30, 9)
        {
        }

        public void Farming()
        {
            Console.WriteLine("Working");
        }

        //public override void Move()
        //{
            
        //}
    }
}
