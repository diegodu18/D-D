using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.GameItems
{
    public interface IDice
    {
        public void AddDice(Dice dice, int amount);
        public int RollDice(Dice dice);
    }
}
