using Infrastracture.Characters.Spells;
using Infrastracture.GameItems;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public short Speed { get; protected set; }
        public bool HasDarkVision { get; protected set; }
        public short? DarkVisionLenght { get; protected set; }
        public ElementalDamageType? DamageResistence { get; protected set; }
        public virtual short LifeSpanPerLevel => 0;

        public virtual IReadOnlyCollection<Spell> GetSpells(short level)
        {
            return Array.Empty<Spell>();
        }

        public virtual IReadOnlyCollection<Spell> GetSpells(object? subType)
        {
            return Array.Empty<Spell>();
        }

        public virtual IReadOnlyCollection<Spell> GetSpells(short level, object? subType)
        {
            return Array.Empty<Spell>();
        }

    }
}
