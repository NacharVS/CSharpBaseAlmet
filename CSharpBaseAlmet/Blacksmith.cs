using CSharpBaseAlmet.Weapons;

namespace CSharpBaseAlmet
{
    internal class Blacksmith : Unit
    {
        public Blacksmith() : base("Blacksmith", 30, 5)
        {

        }

        public void Repair(Weapon weapon)
        {
            weapon.Durability += 10;
        }

    }
}
