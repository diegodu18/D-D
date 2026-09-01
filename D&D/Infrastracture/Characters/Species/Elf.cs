using Infrastracture.Characters.Spells;
using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Elf : Specie
    {
        public Elf(ElfSubType subType) : base(SpecieName.Elf)
        {
            SubType = subType;
            Size = Size.Medium;
            HasDarkVision = true;
            if (subType == ElfSubType.Drow)
            {
                DarkVisionLenght = 120;
                Speed = 30;
            }
            if (subType == ElfSubType.WoodElf)
            {
                Speed = 35;
            }
            if (subType == ElfSubType.HighElf)
            {
                Speed = 30;
            }
        }

        public override IReadOnlyCollection<Spell> GetSpells(short level, object? subType)
        {
            if (subType is not ElfSubType elfSubType)
            {
                throw new ArgumentException("Invalid SubElf.", nameof(subType));
            }

            var spells = new List<Spell>();

            switch (elfSubType)
            {
                case ElfSubType.HighElf:
                    if (level >= 1)
                    {
                        spells.Add(new Prestidigitation());
                    }

                    if (level >= 3)
                    {
                        spells.Add(new DetectMagic());
                    }

                    if (level >= 5)
                    {
                        spells.Add(new MistyStep());
                    }
                    break;

                case ElfSubType.WoodElf:
                    if (level >= 1)
                    {
                        spells.Add(new Druidcraft());
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Longstrider());
                    }

                    if (level >= 5)
                    {
                        spells.Add(new PassWithoutTrace());
                    }
                    break;

                case ElfSubType.Drow:
                    if (level >= 1)
                    {
                        spells.Add(new DancingLights());
                    }

                    if (level >= 3)
                    {
                        spells.Add(new FaerieFire());
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Darkness());
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(elfSubType), elfSubType, "Invalid SubElf.");
            }

            return spells;
        }

        public ElfSubType SubType { get; }
    }

    public enum ElfSubType
    {
        HighElf,
        WoodElf,
        Drow
    }
}
