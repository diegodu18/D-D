using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Orc : Specie
    {
        public Orc() : base(SpecieName.Orc)
        {
            Size = Size.Medium;
            Speed = 30;
            HasDarkVision = true;
            DarkVisionLenght = 120;
        }
    }
}
