using CSharpBaseAlmet;
using CSharpBaseAlmet.Weapons;

Peasant peasant = new Peasant();
IronSword sword = new IronSword();
BronzeMace mace = new BronzeMace();
Footman soldier1 = new Footman("Warrior", 60, 11, 11, 2, mace);
Footman soldier2 = new Footman("Warrior", 60, 11, 10, 2, mace);

Archer archer = new Archer("Ranger", 40, 12, 15, 1);
Healer healer = new Healer();

soldier1.WeaponAttack(soldier2);
soldier2.WeaponAttack(soldier1);
soldier1.WeaponAttack(soldier2);
soldier2.WeaponAttack(soldier1);
soldier1.WeaponAttack(soldier2);
soldier2.WeaponAttack(soldier1);
soldier1.WeaponAttack(soldier2);
soldier2.WeaponAttack(soldier1);


















