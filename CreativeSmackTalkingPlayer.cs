using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
     
    public string Taunt { get; set; }

     public override int Roll()
       {
           Console.WriteLine(@$"{Name} says {Taunt}");
           return new Random().Next(DiceSize) + 1;
       }
    }
}