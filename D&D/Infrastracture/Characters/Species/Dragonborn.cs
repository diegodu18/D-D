using Infrastracture.Characters.Spices;
using Infrastracture.GameItems;

namespace Infrastracture.Characters.Species
{
    public class Dragonborn : Specie
    {
        public ElementalDamageType BreathAttack { get; set; }
        public string Color { get; set; }
        public Dragonborn(DragonbornSubType subType) : base(SpecieName.DragonBorn)
        {
            DraconicAncestry = subType;
            HasDarkVision = true;
            DarkVisionLenght = 60;
            Color = GetDragonbornColor(subType);
            Size = Size.Medium;
            Speed = 30;
            if (subType.Equals(DragonbornSubType.Black) || subType.Equals(DragonbornSubType.Copper))
            {
                BreathAttack = ElementalDamageType.Acid;
                DamageResistence = ElementalDamageType.Acid;
            }
            
            if(subType.Equals(DragonbornSubType.Blue) || subType.Equals(DragonbornSubType.Bronze))
            {
                BreathAttack = ElementalDamageType.Lightning;
                DamageResistence = ElementalDamageType.Lightning;
            }

            if(subType.Equals(DragonbornSubType.Brass) || subType.Equals(DragonbornSubType.Red) || subType.Equals(DragonbornSubType.Gold))
            {
                BreathAttack = ElementalDamageType.Fire;
                DamageResistence = ElementalDamageType.Fire;
            }

            if(subType.Equals(DragonbornSubType.Green))
            {
                BreathAttack = ElementalDamageType.Poison;
                DamageResistence = ElementalDamageType.Poison;
            }

            if (subType.Equals(DragonbornSubType.Silver) || subType.Equals(DragonbornSubType.White))
            {
                BreathAttack = ElementalDamageType.Cold;
                DamageResistence = ElementalDamageType.Cold;
            }

        }

        public DragonbornSubType DraconicAncestry { get; }

        private string GetDragonbornColor(DragonbornSubType subType)
        {
            return subType switch
            {
                DragonbornSubType.Red => "Red",
                DragonbornSubType.Blue => "Blue",
                DragonbornSubType.Green => "Green",
                DragonbornSubType.Black => "Black",
                DragonbornSubType.White => "White",
                DragonbornSubType.Gold => "Gold",
                DragonbornSubType.Silver => "Silver",
                DragonbornSubType.Bronze => "Bronze",
                DragonbornSubType.Copper => "Copper",
                DragonbornSubType.Brass => "Brass",
                _ => throw new ArgumentOutOfRangeException(nameof(subType), subType, null)
            };
        }
    }


    public enum DragonbornSubType
    {
        Red,
        Blue,
        Green,
        Black,
        White,
        Gold,
        Silver,
        Bronze,
        Copper,
        Brass,
    }

   
}
