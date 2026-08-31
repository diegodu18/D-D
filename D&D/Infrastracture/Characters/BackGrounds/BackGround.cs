using Infrastracture.Characters;

namespace Infrastracture.Characters.BackGrounds
{
    public sealed class BackGround
    {
     

        public LoreType Lore { get; private set; }

        public BackGround(LoreType loreType)
        {
            Lore = loreType;
        }

    }

    public enum LoreType
    {
        Nobility,
        Soldier,
        Criminal,
        Acolyte,
        Sage
    }
}
