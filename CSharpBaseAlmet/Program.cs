using CSharpBaseAlmet;
using CSharpBaseAlmet.Weapons;

Peasant peasant = new Peasant();
IronSword sword = new IronSword();
Blacksmith blacksmith = new Blacksmith();
BronseMace mace = new BronseMace();
StoneAxe axe = new StoneAxe();
Footman soldier1 = new Footman("Warrior", 60, 11, 11, 2, mace);
Footman soldier2 = new Footman("Warrior", 60, 11, 10, 2, axe);

Archer archer = new Archer("Ranger", 40, 12, 15, 1);
Healer healer = new Healer();

soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);

soldier1.ShowBaseInfo();