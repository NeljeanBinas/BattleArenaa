
using System;

namespace BTTLE.Characters
{
    //Base Character Sheet Will Changfe Later According To the Theme of wehat Character i want
    //Hololivew Base Myth JP 
    //Crew Marine Masybr SRB Tyoe Holo 

    internal class Character
    {
        //Set Holomem ID 
        public string Name { get; set; }

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

    }
}
