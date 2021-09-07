using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
           Console.WriteLine("Roll your own die!\nPlease enter your roll...");
           return int.Parse(Console.ReadLine());
        }
    }
}