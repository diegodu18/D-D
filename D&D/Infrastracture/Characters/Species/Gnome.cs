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

        public GnomeSubType SubType { get; }
    }

    public enum GnomeSubType
    {
        ForestGnome,
        RockGnome
    }
}
