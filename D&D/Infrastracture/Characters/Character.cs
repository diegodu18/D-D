using Infrastracture.Characters.Equipment;
using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters
{
    public  abstract class Character
    {
        protected Character()
        {
        }

        protected Character(string name, Specie specie, short level)
        {
            Name = name;
            Specie = specie;
            Level = level;
            LifeSpan = (short)(level * specie.LifeSpanPerLevel);
        }

        public string Name { get; set; }
        public short Level { get; set; } = 1;
        public short LifeSpan { get; set; }
        public Specie Specie { get; set; }
        public Infrastracture.Characters.Abilities.Abilities Abilities { get; set; }
        public List<Armours>? Armour { get; set; }
        public List<Wepons>? Wepons { get; set; }
        public List<Spells.Spell> Spells { get; set; } = new List<Spells.Spell>();

    }
}
