using Infrastracture.Characters.Spices;
using Infrastracture.Characters.Classes;
using Infrastracture.Characters.BackGrounds;

namespace Infrastracture.Characters.CharacterBuilder
{
    public sealed class CharacterCreationBuilder
    {
        private readonly PlayableCharacter character;

        private CharacterCreationBuilder(PlayableCharacter character)
        {
            this.character = character;
        }

        public static CharacterCreationBuilder Create(string name, ClassType classType)
        {
            var character = PlayableCharacterFactory.Create(classType);
            character.Name = name;

            return new CharacterCreationBuilder(character);
        }

        public CharacterCreationBuilder WithBackground(BackGround.LoreType loreType)
        {
            var background = new BackGround(loreType);

            return this;
        }

        public CharacterCreationBuilder WithSpecie(SpecieName specieName)
        {
            var specie = new Specie(specieName);

            return this;
        }

        public PlayableCharacter Build()
        {
            return character;
        }
    }
}
