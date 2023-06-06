using CSharpBaseAlmet;

Footman soldier1 = new Footman("Warrior", 60, 11, 11, 2);
Footman soldier2 = new Footman("Warrior", 60, 11, 10, 2);
Peasant peasant = new Peasant();
Archer archer = new Archer("Ranger", 40, 12, 15, 1);
Healer healer = new Healer();

soldier1.InflictDamage(peasant);
healer.HealSomebody(peasant);
healer.ShowReource();
peasant.ShowBaseInfo();

















