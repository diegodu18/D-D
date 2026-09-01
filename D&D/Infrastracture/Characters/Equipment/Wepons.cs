using Infrastracture.GameItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Equipment
{
    public class Wepons
    {
        public short ItemID { get; set; }
        public string Name { get; set; }
        public PhysicalDamageType DamageType { get; set; }
        public ElementalDamageType? ElementalDamageType { get; set; }
    }
}
