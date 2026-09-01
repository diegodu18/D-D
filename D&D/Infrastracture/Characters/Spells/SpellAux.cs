using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Spells
{
    public enum SpellType
    {
        /// <summary>
        ///  Inflicts raw hit poshort damage to one or many targets.
        /// </summary>
        Damage,

       /// <summary>
       /// Restores hit poshorts, removes negative conditions, or revives the dead.
       /// </summary>
        Healing,

       /// <summary>
       /// Enhances allies' stats, grants mobility, or solves out-of-combat puzzles.
       /// </summary>
        Buff,

       /// <summary>
       /// Weakens enemies, restricts their movement, or takes them out of the fight.
       /// </summary>
        Debuff,
    }
    public enum SpellLevel
    {
        Cantrip = 0,
        Level1 = 1,
        Level2 = 2,
        Level3 = 3,
        Level4 = 4,
        Level5 = 5,
        Level6 = 6,
        Level7 = 7,
        Level8 = 8,
        Level9 = 9
    }

    public enum SchoolOfMagic
    {
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation
    }
}
