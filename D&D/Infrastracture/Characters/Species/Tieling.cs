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
    }


    public enum TielingSubType
    {
        Chthonic,
        Infernal,
        Abyssal,
    }

}
