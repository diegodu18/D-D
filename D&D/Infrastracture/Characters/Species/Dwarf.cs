using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Dwarf : Specie
    {
        public Dwarf() : base(SpecieName.Dwarf)
        {
            Size = Size.Medium;
            Speed = 30;
            HasDarkVision = true;
            DarkVisionLenght = 120;
        }

        public override short LifeSpanPerLevel => 1;
    }
}
