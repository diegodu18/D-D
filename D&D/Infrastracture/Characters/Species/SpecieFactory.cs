using Infrastracture.Characters.Spices;

namespace Infrastracture.Characters.Species
{
    public static class SpecieFactory
    {
        public static Specie Create(SpecieName name)
        {
            return name switch
            {
                SpecieName.Dwarf => new Dwarf(),
                SpecieName.Halfling => new Halfling(),
                SpecieName.Orc => new Orc(),
                _ => throw new ArgumentException(
                    "Invalid Subtype",
                    nameof(name))
            };
        }

        public static Elf Create(ElfSubType subType) => new(subType);

        public static Gnome Create(GnomeSubType subType) => new(subType);

        public static Goliath Create(GoliathSubType subType) => new(subType);

        public static Dragonborn Create(DragonbornSubType subType) => new(subType);
        public static Human Create(Size size) => new(size);
        public static Tieling Create(TielingSubType subType, Size size) => new(subType, size);
    }
}
