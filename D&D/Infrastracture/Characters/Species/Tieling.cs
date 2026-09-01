using Infrastracture.Characters.Spells;
using Infrastracture.Characters.Spices;
using Infrastracture.GameItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Tieling : Specie
    {
        public TielingSubType FiendishLegacy { get; set; }
        public Tieling(TielingSubType subType, Size size) : base(SpecieName.Tieling)
        {
            FiendishLegacy = subType;
            Size = size;
            HasDarkVision = true;
            DarkVisionLenght = 60;
            switch(subType) {
                case TielingSubType.Chthonic:
                    DamageResistence = ElementalDamageType.Necrotic;
                    break;
                case TielingSubType.Infernal:
                    DamageResistence = ElementalDamageType.Fire;
                    break;
                case TielingSubType.Abyssal:
                    DamageResistence = ElementalDamageType.Poison;
                    break;
            }
        }

        public override IReadOnlyCollection<Spell> GetSpells(short level, object? subType)
        {
            if (subType is not TielingSubType tielingSubType)
            {
                throw new ArgumentException("Invalid SubTieling.", nameof(subType));
            }

            var spells = new List<Spell>();

            switch (tielingSubType)
            {
                case TielingSubType.Chthonic:
                    if (level >= 1)
                    {
                        spells.Add(new Spell { SpellName = SpellName.ChillTouch });
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Spell { SpellName = SpellName.FalseLife });
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Spell { SpellName = SpellName.RayOfEnfeeblement });
                    }
                    break;

                case TielingSubType.Infernal:
                    if (level >= 1)
                    {
                        spells.Add(new Spell { SpellName = SpellName.FireBolt });
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Spell { SpellName = SpellName.HellishRebuke });
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Spell { SpellName = SpellName.Darkness });
                    }
                    break;

                case TielingSubType.Abyssal:
                    if (level >= 1)
                    {
                        spells.Add(new Spell { SpellName = SpellName.PoisonSprey });
                    }

                    if (level >= 3)
                    {
                        spells.Add(new Spell { SpellName = SpellName.RayOfSickness });
                    }

                    if (level >= 5)
                    {
                        spells.Add(new Spell { SpellName = SpellName.HoldPerson });
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(tielingSubType), tielingSubType, "Invalid SubTieling.");
            }

            return spells;
        }
    }


    public enum TielingSubType
    {
        Chthonic,
        Infernal,
        Abyssal,
    }

}
