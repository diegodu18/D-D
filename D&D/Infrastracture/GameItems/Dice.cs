using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastracture.GameItems
{
    public class Dice : IDice
    {
        [MaxLength(20)]
        public int Return { get; set; }

        public int DiceAmount = 1;

        public void AddDice(Dice dice, int amount)
        {
           this.DiceAmount += amount;

        }

        public int RollDice(Dice dice)
        {
            return this.Return = Random.Shared.Next(0, 20) * this.DiceAmount;
        }
    }


}
