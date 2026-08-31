using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Human : Specie
    {
        public Human(Size size) : base(SpecieName.Human)
        {
            Size = size;
            Speed = 30;
            HasDarkVision = false;
        }


    }
}
