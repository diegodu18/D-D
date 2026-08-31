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

        public ElfSubType SubType { get; }
    }

    public enum ElfSubType
    {
        HighElf,
        WoodElf,
        Drow
    }
}
