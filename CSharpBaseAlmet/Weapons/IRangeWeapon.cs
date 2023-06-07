namespace CSharpBaseAlmet.Weapons
{
    interface IRangeWeapon
    {
        public int RangeDamage { get; set; }

        public int Range { get; set; }

        public void Shoot();
        public void ShowInfo();
    }
}
