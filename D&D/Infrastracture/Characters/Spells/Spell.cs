using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Spells
{
    public abstract class Spell
    {
        public short SpellID { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public SpellLevel SpellLevel {  get; set; }
        public SchoolOfMagic SchoolOfMagic { get; set; }
        public SpellType SpellType { get; set; }
        public short? Rounds { get; set; }
        public bool RequiresConcentration { get; set; }
    }
}
