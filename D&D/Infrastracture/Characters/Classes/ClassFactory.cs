using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.Characters.Classes
{
    public static class ClassFactory
    {
        public static ClassType Create(ClassName className)
        {
            return className switch
            {
                ClassName.Fighter => new Fighter(),
                ClassName.Wizard => new Wizard(),
                ClassName.Ranger => new Ranger(),
                ClassName.Rogue => new Rogue(),
                ClassName.Cleric => new Cleric(),
                _ => throw new ArgumentOutOfRangeException(
                    nameof(className),
                    className,
                    "Tipo de clase no válido.")
            };
        }
    }
}
