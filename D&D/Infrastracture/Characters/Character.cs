using Infrastracture.Characters.Equipment;
using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters
{
    public  abstract class Character
    {
        protected Character()
        {
        }

        protected Character(string name, Specie specie, int level)
        {
            Name = name;
            Specie = specie;
            Level = level;
            LifeSpan = level * specie.LifeSpanPerLevel;
        }

        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int LifeSpan { get; set; }
        public Specie Specie { get; set; }
        public Infrastracture.Characters.Abilities.Abilities Abilities { get; set; }
        public Armours? Armour { get; set; }
        public Wepons? Wepons { get; set; }

    }
}
