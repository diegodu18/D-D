using Infrastracture.Characters.CharacterBuilder;

namespace Infrastracture.Characters.Spices
{
    public sealed class Specie : ICharacterModifier
    {
        public Specie(SpecieName name)
        {
            Name = name;
            Type = SpecieType.Humanoide;
            Modifiers = name switch
            {
                SpecieName.Human => new CharacterModifiers(),
                SpecieName.Elf => new CharacterModifiers(Speed: 2, Dexterity: 2, Intelligence: 1, Constitution: -1),
                SpecieName.Dwarf => new CharacterModifiers(LifeAmount: 10, ArmorClass: 2, Constitution: 2, Speed: -1),
                SpecieName.Orc => new CharacterModifiers(LifeAmount: 15, MeleeAttack: 2, Strength: 3, Intelligence: -2),
                SpecieName.Goblin => new CharacterModifiers(Speed: 2, Dexterity: 2, Strength: -1, LifeAmount: -5),
                SpecieName.Goliath => new CharacterModifiers(LifeAmount: 20, Strength: 2, Speed: -2),
                SpecieName.Halfling => new CharacterModifiers(Dexterity: 2, Speed: 1, Strength: -1),
                SpecieName.Tieling => new CharacterModifiers(MagicPower: 2, Intelligence: 1, Charisma: 2),
                SpecieName.DragonBorn => new CharacterModifiers(LifeAmount: 10, MagicPower: 2, Charisma: 1),
                _ => throw new ArgumentOutOfRangeException(nameof(name), name, "Especie no válida.")
            };
        }

        public SpecieType Type { get; }
        public SpecieName Name { get; }
        public CharacterModifiers Modifiers { get; }
    }
}
