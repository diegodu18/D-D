using Infrastracture.Characters.BackGrounds;
using Infrastracture.Characters.Classes;
using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters.CharacterBuilder
{
    public static class PlayableCharacterFactory
    {
        public static PlayableCharacter Create(ClassType classType)
        {
            return classType switch
            {
                Fighter => new PlayableCharacter(classType),
                Wizard => new PlayableCharacter(classType),
                Ranger => new PlayableCharacter(classType),
                Rogue => new PlayableCharacter(classType),
                Cleric => new PlayableCharacter(classType),
                _ => throw new ArgumentOutOfRangeException(nameof(classType), classType, "Tipo de clase no válido.")
            };
        }

        public static PlayableCharacter Create(string name, SpecieName specieName, ClassType classType, int level)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            ArgumentNullException.ThrowIfNull(classType);

            if (level < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(level), level, "El nivel debe ser mayor que cero.");
            }

            return new PlayableCharacter(name, new Specie(specieName), classType, level);
        }

        public static PlayableCharacter Create(ClassType classType, BackGround.LoreType loreType)
        {
            return Create(classType, new BackGround(loreType));
        }

        public static PlayableCharacter Create(ClassType classType, BackGround lore)
        {
            var character = Create(classType);
            return character;
        }
    }
}
