using CSharpBaseAlmet;
using CSharpBaseAlmet.Weapons;

void Method1()
{
    Console.WriteLine("SimpleMove");
}
void Method2()
{
    Console.WriteLine("BrutalMove");
}
void Method3()
{
    Console.WriteLine("Move");
}

Peasant peasant = new Peasant();
Footman footman = new Footman();
peasant.healthChangedEvent += Method1;
peasant.healthChangedEvent += Method2;
peasant.healthChangedEvent += Method3;
footman.InflictDamage(peasant);







//IronSword sword = new IronSword();
//BronzeMace mace = new BronzeMace();
//StoneAxe axe = new StoneAxe();
//Footman soldier1 = new Footman("Warrior", 60, 11, 11, 2, mace);
//Footman soldier2 = new Footman("Warrior", 60, 11, 10, 2, axe);

//Archer archer = new Archer("Ranger", 40, 12, 15, 1);
//Healer healer = new Healer();

//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);
//soldier1.InflictDamage(soldier2);
//soldier2.InflictDamage(soldier1);

//soldier1.ShowBaseInfo();
























