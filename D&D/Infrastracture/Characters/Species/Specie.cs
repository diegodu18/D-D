using Infrastracture.Characters.Abilities;

namespace Infrastracture.Characters.Spices
{
    public abstract class Specie 
    {
        protected Specie(SpecieName name)
        {
            Name = name;
        }

        public SpecieType Type { get; }
        public SpecieName Name { get; }
        public Size Size { get;  set; }
        public int Speed { get; protected set; }
        public bool HasDarkVision { get; protected set; }
        public int? DarkVisionLenght { get; protected set; }
        public ElementalDamageType? DamageResistence { get; protected set; }
        public virtual int LifeSpanPerLevel => 0;

    }
}
