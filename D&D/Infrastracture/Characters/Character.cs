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
            this.specie = specie;
            Level = level;
        }

        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public int LifeSpan { get; set; }
        public Specie specie { get; set; }
        public Infrastracture.Characters.Abilities.Abilities abilities { get; set; }

    }
}
