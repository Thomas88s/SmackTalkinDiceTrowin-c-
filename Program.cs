using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer player5 = new SmackTalkingPlayer();
            player5.Name = "Cut Throat Jenkins";
            player5.Taunt = "You rollin garbage, man!";
        
            player5.Play(large);

            Console.WriteLine("-------------------");

            OneHigherPlayer player6 = new OneHigherPlayer();
            player6.Name = "Slick Rick";

            player6.Play(player5);

            Console.WriteLine("-------------------");

            HumanPlayer player7 = new HumanPlayer();
            player7.Name = "Meat Bag";

            player7.Play(player6);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer player8 = new CreativeSmackTalkingPlayer();
            player8.Name = "Leroy Jenkins!";
            player8.Taunt = "blah blah";

            player8.Play(player7);

            Console.WriteLine("-------------------");

            SoreLoserPlayer player9 = new SoreLoserPlayer();
            player9.Name = "Big ol'Baby";

            player9.Play(player8);

             Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, player5, player6, player7, player8, player9
            };

            
            // Taunt blahBlah = new Taunt(@"blah blah");
            // Taunt blahBlah2 = new Taunt(@"blah2 blah2");
            // Taunt blahBlah3 = new Taunt(@"blah3 blah3");
            
            // List<Taunt> taunts = new List<Taunt>()
            // {
            //  blahBlah,
            //  blahBlah2,
            //  blahBlah3
            // }; 


            // var randomTaunt = new Random();
            // var randomizedTaunts = taunts.OrderBy(taunt => randomTaunt.Next());
            // var tauntPack5 = randomizedTaunts.Take(1);

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}