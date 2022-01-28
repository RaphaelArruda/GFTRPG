// See https://aka.ms/new-console-template for more information
using GFTRPG.SRC.Entites;

Archer Aela = new Archer("Aela", "Nordic", "Archer", 22, 32);
Warrior Dovakin = new Warrior("Dovakin", "Nordic", "Warrior", 30, 40);
Mage Serena = new Mage("Serena", "Vampire", "Mage", 10, 25);

Console.WriteLine(Aela.Atack(8));
Console.WriteLine(Dovakin.Atack(11));
Console.WriteLine(Serena.Atack(20));