using Infrastracture.Characters.Classes;
using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters.CharacterBuilder
{
    public  class PlayableCharacter : Character
    {
        internal PlayableCharacter(ClassType classType)
        {
            ClassType = classType;
        }

        internal PlayableCharacter(string name, Specie specie, ClassType classType, int level)
            : base(name, specie, level)
        {
            ClassType = classType;
        }

        public ClassType ClassType { get; }
        public Guid UserId { get; set; }
        public int Id { get; set; }

    }
}