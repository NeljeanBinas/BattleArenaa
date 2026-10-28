using BTTLE.Characters;

Character marine = new Character(
    name: "Houshou Marine",
    maxHealth: 120,
    attackPower: 25,
    defense: 10,
    maxMana: 60,
    speed: 15
);

Character gura = new Character(
    name: "Gawr Gura",
    maxHealth: 90,
    attackPower: 20,
    defense: 5,
    maxMana: 100,
    speed: 20
);


// Test Marine attacking Gura
marine.Attack(gura);

Console.WriteLine($"{gura.Name}'s HP: {gura.Health}/{gura.MaxHealth}");