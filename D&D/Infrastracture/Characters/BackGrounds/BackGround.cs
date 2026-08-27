using Infrastracture.Characters.CharacterBuilder;

namespace Infrastracture.Characters.BackGrounds
{
    public sealed class BackGround : ICharacterModifier
    {
        public enum LoreType
        {
            Nobility,
            Orphan,
            Hermit,
            Veteran,
            Criminal
        }

        public BackGround(LoreType loreType)
        {
            Type = loreType;
            Modifiers = loreType switch
            {
                LoreType.Nobility => new CharacterModifiers(Strength: -1, Wisdom: 2, Charisma: 4),
                LoreType.Orphan => new CharacterModifiers(LifeAmount: -10, Speed: 2, Dexterity: 3, Charisma: -2),
                LoreType.Hermit => new CharacterModifiers(Initiative: -1, Intelligence: 2, Wisdom: 4, Charisma: -3),
                LoreType.Veteran => new CharacterModifiers(LifeAmount: 15, MeleeAttack: 3, ArmorClass: 2, Speed: -1),
                LoreType.Criminal => new CharacterModifiers(Initiative: 3, Dexterity: 2, Wisdom: -1, Charisma: -2),
                _ => throw new ArgumentOutOfRangeException(nameof(loreType), loreType, "Tipo de background no válido.")
            };
        }

        public LoreType Type { get; }
        public CharacterModifiers Modifiers { get; }
    }
}
