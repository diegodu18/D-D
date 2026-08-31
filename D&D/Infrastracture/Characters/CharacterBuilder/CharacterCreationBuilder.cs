using CharacterAbilities = global::Infrastracture.Characters.Abilities.Abilities;
using Infrastracture.Characters.BackGrounds;
using Infrastracture.Characters.Classes;
using Infrastracture.Characters.Species;
using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters.CharacterBuilder
{
    public sealed class CharacterCreationBuilder
    {
        private string? name;
        private ClassType? classType;
        private Specie? specie;
        private BackGround? background;
        private CharacterAbilities? abilities;
        private int level = 1;

        private CharacterCreationBuilder(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            this.name = name;
        }

        public static CharacterCreationBuilder Create(string name)
        {
            return new CharacterCreationBuilder(name);
        }

        public CharacterCreationBuilder CreateClass(ClassType classType)
        {
            ArgumentNullException.ThrowIfNull(classType);
            this.classType = classType;

            return this;
        }

        public CharacterCreationBuilder CreateBackground(LoreType loreType)
        {
            background = new BackGround(loreType);

            return this;
        }

        public CharacterCreationBuilder CreateSpecie(SpecieName specieName)
        {
            specie = SpecieFactory.Create(specieName);

            return this;
        }

        public CharacterCreationBuilder CreateSpecie(ElfSubType subType)
        {
            specie = SpecieFactory.Create(subType);

            return this;
        }

        public CharacterCreationBuilder CreateSpecie(GnomeSubType subType)
        {
            specie = SpecieFactory.Create(subType);

            return this;
        }

        public CharacterCreationBuilder CreateSpecie(GoliathSubType subType)
        {
            specie = SpecieFactory.Create(subType);

            return this;
        }

        public CharacterCreationBuilder CreateSpecie(DragonbornSubType subType)
        {
            specie = SpecieFactory.Create(subType);

            return this;
        }

        public CharacterCreationBuilder CreateAbilities(CharacterAbilities abilities)
        {
            ArgumentNullException.ThrowIfNull(abilities);
            this.abilities = abilities;

            return this;
        }

        public CharacterCreationBuilder AtLevel(int level)
        {
            if (level < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(level), level, "El nivel debe ser mayor que cero.");
            }

            this.level = level;
            return this;
        }

        public PlayableCharacter Build()
        {
            if (classType is null)
            {
                throw new InvalidOperationException("La clase del personaje es obligatoria.");
            }

            if (specie is null)
            {
                throw new InvalidOperationException("La especie del personaje es obligatoria.");
            }

            if (background is null)
            {
                throw new InvalidOperationException("El background del personaje es obligatorio.");
            }

            if (abilities is null)
            {
                throw new InvalidOperationException("Las habilidades del personaje son obligatorias.");
            }

            return new PlayableCharacter(name!, specie, background, classType, level, abilities!);
        }
    }
}
