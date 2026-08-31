using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Halfling : Specie
    {
        public Halfling() : base(SpecieName.Halfling)
        {
            Size = Size.Small;
            HasDarkVision = false;
            Speed = 30;
        }
    }
}
