using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Equipment
{
    public abstract class Sword : Wepons
    {
        public Sword()
        {
            DamageType = GameItems.PhysicalDamageType.Slashing;
        }
    }
}
