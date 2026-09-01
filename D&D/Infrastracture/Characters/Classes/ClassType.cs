using Infrastracture.Characters.Spells;

namespace Infrastracture.Characters.Classes
{
    public abstract class ClassType
    {
        public string Name { get; protected set; }

        public virtual IReadOnlyCollection<Spell> GetSpells(short level)
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