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
                        spells.Add(new Spell { SpellName = SpellName.Prestidigitation });
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Spell { SpellName = SpellName.DetectMagic });
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Spell { SpellName = SpellName.MistyStep });
                    }
                    break;

                case ElfSubType.WoodElf:
                    if (level >= 1)
                    {
                        spells.Add(new Spell { SpellName = SpellName.Druidcraft });
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Spell { SpellName = SpellName.Longstrider });
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Spell { SpellName = SpellName.PassWithoutTrace });
                    }
                    break;

                case ElfSubType.Drow:
                    if (level >= 1)
                    {
                        spells.Add(new Spell { SpellName = SpellName.DancingLights });
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Spell { SpellName = SpellName.FaerieFire });
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Spell { SpellName = SpellName.Darkness });
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
