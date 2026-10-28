using System;
using System.Collections.Generic;
using System.Text;

using BTTLE.Characters;

namespace BTTLE
{
    internal class BattleArena
    {
        public void StartBattle(Character fighter1, Character fighter2)
        {
            while (!fighter1.IsDead && !fighter2.IsDead)
            {
                int damageDealt = fighter1.Attack(fighter2);

                Console.WriteLine(
                    $"{fighter1.Name} attacks {fighter2.Name} for {damageDealt} damage!");

                Console.WriteLine(
                    $"{fighter2.Name}: {fighter2.Health}/{fighter2.MaxHealth} HP");

                if (fighter2.IsDead)
                {
                    Console.WriteLine($"{fighter2.Name} has been defeated!");
                    break;
                }

                damageDealt = fighter2.Attack(fighter1);

                Console.WriteLine(
                    $"{fighter2.Name} attacks {fighter1.Name} for {damageDealt} damage!");

                Console.WriteLine(
                    $"{fighter1.Name}: {fighter1.Health}/{fighter1.MaxHealth} HP");

                if (fighter1.IsDead)
                {
                    Console.WriteLine($"{fighter1.Name} has been defeated!");
                }
            }
        }
    }
}
