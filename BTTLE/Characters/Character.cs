
using System;

namespace BTTLE.Characters
{
    //Base Character Sheet Will Changfe Later According To the Theme of wehat Character i want
    //Hololivew Base Myth JP 
    //Crew Marine Masybr SRB Tyoe Holo 

    internal class Character
    {
        //Set Holomem ID 
        public string Name { get; set; } = "";

        //Set Holomem HPmx
        public int MaxHealth { get; set; }

        //Set Holomem HP
        public int Health { get; set; }

        //Set Holomem ATK
        public int AttackPower { get; set; }

        //Set Holomem DEF
        public int Defense { get; set; }

        //Set Holomem MPmx
        public int MaxMana { get; set; }

        //Set Holomem MP
        public int Mana { get; set; }

        //Set Holomem SPmx (Probably Optiona;l When I Do the CHAR LAter )
        public int Speed { get; set; }

        //Set Holomem Current Health and Mana BAsed on defaault Stats 
        public Character(
            string name,
            int maxHealth,
            int attackPower,
            int defense,
            int maxMana,
            int speed)
        {
            Name = name;

            MaxHealth = maxHealth;
            Health = maxHealth;

            AttackPower = attackPower;
            Defense = defense;

            MaxMana = maxMana;
            Mana = maxMana;

            Speed = speed;
        }

        // HP Damage and Update Scale Indicating SUpressed/Taken DMG
        public void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }
        }


        // Attacks another Holomem But TEnds to the Def Pts
        public void Attack(Character target)
        {
            int damage = AttackPower - target.Defense;

            if (damage < 1)
            {
                damage = 1;
            }

            target.TakeDamage(damage);
        }

    }
}

