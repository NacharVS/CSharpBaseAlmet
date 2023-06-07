using CSharpBaseAlmet;
using CSharpBaseAlmet.Weapons;

Peasant peasant = new Peasant();
IronSword sword = new IronSword();
BronzeMace mace = new BronzeMace();
StoneAxe axe = new StoneAxe();
Footman soldier1 = new Footman("Warrior", 60, 11, 2, 2, axe);
Footman soldier2 = new Footman("Warrior", 60, 11, 2, 2, mace);
Smith smith1 = new Smith();

Archer archer = new Archer("Ranger", 40, 12, 15, 1);
Healer healer = new Healer();

//soldier1.WeaponAttack(soldier2); 
//soldier2.WeaponAttack(soldier1); 
//soldier1.WeaponAttack(soldier2); 
//soldier2.WeaponAttack(soldier1); 
//soldier1.WeaponAttack(soldier2); 
//soldier2.WeaponAttack(soldier1); 

soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
axe.ShowDurability();
mace.ShowDurability();
smith1.Repair(axe);
axe.ShowDurability();
mace.ShowDurability();
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
soldier1.InflictDamage(soldier2);
soldier2.InflictDamage(soldier1);
Console.WriteLine();
soldier1.ShowBaseInfo();
soldier2.ShowBaseInfo();

















