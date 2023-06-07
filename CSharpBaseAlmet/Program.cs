using CSharpBaseAlmet;
using CSharpBaseAlmet.Buildings;
using CSharpBaseAlmet.Weapons;

void Method1(int pHealth)
{
    Console.WriteLine($"Current health = {pHealth}");
}

void Method2()
{
    Console.WriteLine("BrutalMove");
}

void Method3()
{
    Console.WriteLine("Move");
}

//Peasant peasant = new Peasant();
//peasant.moving = Method1;
//peasant.Move();
//peasant.moving = Method2;
//peasant.Move();
//peasant.moving = Method3;
//peasant.Move();
//IronSword sword = new IronSword();
//BronzeMace mace = new BronzeMace();
//StoneAxe axe = new StoneAxe();
//Footman soldier1 = new Footman("Warrior", 60, 11, 2, 2, axe);
//Footman soldier2 = new Footman("Warrior", 60, 11, 2, 2, mace);
//Smith smith1 = new Smith();

//Archer archer = new Archer("Ranger", 40, 12, 15, 1);
//Healer healer = new Healer();

//peasant.HealthChangedEvent += Method1;
//peasant.HealthChangedEvent += Method2;
//peasant.HealthChangedEvent += Method3;

//soldier1.CurrentWeapon.DurabilityChangedEvent += axe.ShowDurability;

//soldier1.InflictDamage(peasant);
//soldier1.InflictDamage(peasant);

//soldier1.WeaponAttack(soldier2); 
//soldier2.WeaponAttack(soldier1); 
//soldier1.WeaponAttack(soldier2); 
//soldier2.WeaponAttack(soldier1); 
//soldier1.WeaponAttack(soldier2); 
//soldier2.WeaponAttack(soldier1); 

//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//axe.ShowDurability();
//mace.ShowDurability();
//smith1.Repair(axe);
//axe.ShowDurability();
//mace.ShowDurability();
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//Console.WriteLine();
//soldier1.ShowBaseInfo();
//soldier2.ShowBaseInfo();


//IRangeWeapon weapon1 = new Cannon();
//IRangeWeapon weapon2 = new Bow();

//weapon1.Shoot();
//weapon1.ShowInfo();
//weapon2.Shoot();
//weapon2.ShowInfo();
//weapon1.Shoot();
//weapon1.ShowInfo();
//weapon2.Shoot();
//weapon2.ShowInfo();

IBarrack building1 = new Barrack();

building1.ShowInfo();














