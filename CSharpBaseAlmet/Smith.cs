using CSharpBaseAlmet.Weapons;

namespace CSharpBaseAlmet
{
    internal class Smith : Unit
    {
        public Weapon CurrentWeapon { get; set; }
        
        public Smith() : base("Smith", 30, 5)
        {
        }

        public void Repair(Weapon weapon)
        {
            weapon.Durability += 10;
        }
    }
}
