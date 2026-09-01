using Infrastracture.Characters.Spells;
using AbilitiesNS = Infrastracture.Characters.Abilities;

namespace Infrastracture.Characters.Classes
{
    public abstract class ClassType
    {
        public string Name { get; protected set; }

        public virtual IReadOnlyCollection<Spell> GetSpells(ClassName className, short level)
        {
            return Array.Empty<Spell>();
        }

    }

    public enum ClassName
    {
        Fighter,
        Wizard,
        Ranger,
        Rogue,
        Cleric
    }
}