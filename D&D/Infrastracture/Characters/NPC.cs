using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters
{
    public class NPC : Character
    {
        public NPC(string name, int level, int lifeSpan, Specie specieType)
        {
            Name = name;
            Level = level;
            LifeSpan = lifeSpan;
            Specie = specieType;

        }

        public bool IsFriendly { get; set; }
    }
}
