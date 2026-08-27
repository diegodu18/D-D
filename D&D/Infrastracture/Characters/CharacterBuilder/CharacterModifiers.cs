namespace Infrastracture.Characters.CharacterBuilder
{
    public readonly record struct CharacterModifiers(
        int LifeAmount = 0,
        int RangedPower = 0,
        int MeleeAttack = 0,
        int MagicPower = 0,
        int ArmorClass = 0,
        int Speed = 0,
        int Initiative = 0,
        int Strength = 0,
        int Dexterity = 0,
        int Constitution = 0,
        int Intelligence = 0,
        int Wisdom = 0,
        int Charisma = 0);

    public interface ICharacterModifier
    {
        CharacterModifiers Modifiers { get; }
    }
}
