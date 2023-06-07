using CSharpBaseAlmet;
using CSharpBaseAlmet.Weapons;

Peasant peasant = new Peasant();
IronSword sword = new IronSword();
Footman soldier1 = new Footman("Warrior", 60, 11, 11, 2, sword);
Footman soldier2 = new Footman("Warrior", 60, 11, 10, 2);

Archer archer = new Archer("Ranger", 40, 12, 15, 1);
Healer healer = new Healer();

soldier1.WeaponAttack(soldier2);
soldier1.WeaponAttack(soldier2);
soldier1.WeaponAttack(soldier2);
//test commit
soldier2.ShowBaseInfo();

















