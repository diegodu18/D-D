using Infrastracture.Characters.Spells;
using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Gnome : Specie
    {
        public Gnome(GnomeSubType subType) : base(SpecieName.Gnome)
        {
            SubType = subType;
            Size = Size.Small;
            Speed = 30;
            HasDarkVision = true;
            DarkVisionLenght = 60;
        }

        public override IReadOnlyCollection<Spell> GetSpells(object? subType)
        {
            var spells = new List<Spell>();

            switch (subType) {
                case GnomeSubType.ForestGnome:
                    spells.Add(new Spell { SpellName = SpellName.SpeakWithAnimals });
                    spells.Add(new Spell { SpellName = SpellName.MinorIlusion });
                    break;
                case GnomeSubType.RockGnome:
                    spells.Add(new Spell { SpellName = SpellName.Mending });
                    spells.Add(new Spell { SpellName = SpellName.Prestidigitation });
                    break;
            }

            return spells;
        }

        public GnomeSubType SubType { get; }
    }

    public enum GnomeSubType
    {
        ForestGnome,
        RockGnome
    }
}
