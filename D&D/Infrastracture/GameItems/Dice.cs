using System;

namespace Infrastracture.GameItems
{
    public static class Dice
    {
        public static short DiceAmount { get; private set; } = 1;

        public static void AddDice(short amount)
        {
            DiceAmount += amount;
        }

        public static short RollDice()
        {
            var result = 0;

            for (var die = 0; die < DiceAmount; die++)
            {
                result += Random.Shared.Next(1, 21);
            }

            return result;
        }
    }
}
