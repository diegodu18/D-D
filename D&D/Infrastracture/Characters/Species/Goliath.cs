using Infrastracture.Characters.Spices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Species
{
    public class Goliath : Specie
    {
        public Goliath(GoliathSubType subType) : base(SpecieName.Goliath)
        {
            SubType = subType;
            Speed = 35;
            HasDarkVision = false;
        }

        public GoliathSubType SubType { get; }
    }

    public enum GoliathSubType
    {
       CloudJaunt,
       FireBurn,
       FrostChill,
       HillsTumble,
       StoneEndurence,
       StormThunder
    }
}
