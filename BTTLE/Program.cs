
using BTTLE;
using BTTLE.Characters;

//baTTLE IS AT LIGHT SPEED FIX LATER 

// Create the fighters
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

// Create the arena and start the battle
BattleArena arena = new BattleArena();
arena.StartBattle(marine, gura);
