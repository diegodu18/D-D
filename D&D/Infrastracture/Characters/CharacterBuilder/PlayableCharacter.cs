using Infrastracture.Characters.Classes;
using Infrastracture.Characters.Spices;
using Infrastracture.Characters.BackGrounds;
using CharacterAbilities = global::Infrastracture.Characters.Abilities.Abilities;
using Infrastracture.Characters.Abilities;

namespace Infrastracture.Characters.CharacterBuilder
{
    public  class PlayableCharacter : Character
    {
        internal PlayableCharacter(string name, Specie specie, BackGround background, ClassType classType, int level, CharacterAbilities abilities)
            : base(name, specie, level)
        {
            Background = background;
            ClassType = classType;
            Abilities = abilities;
        }

        public ClassType ClassType { get; }
        public BackGround Background { get; }
        public Guid UserId { get; set; }
        public int Id { get; set; }
        public Skills Senses { get; set; }

    }
}