using System;
using System.Collections.Generic;

namespace HotPotatoGame
{
    public class HotPotato
    {
        public void Run()
        {
            Console.Write("Enter the players (comma-separated): ");
            string input = Console.ReadLine();
            string[] players = input.Split(',');

            Console.Write("Enter the elimination number: ");
            int eliminationNumber = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            foreach (var player in players)
            {
                queue.Enqueue(player.Trim());
            }

            while (queue.Count > 1)
            {
                for (int i = 1; i < eliminationNumber; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }

                string eliminatedPlayer = queue.Dequeue();
                Console.WriteLine($"Eliminated: {eliminatedPlayer}");
            }

            string winner = queue.Dequeue();
            Console.WriteLine($"Winner: {winner}");
        }

        static void Main(string[] args)
        {
            HotPotato game = new HotPotato();
            game.Run();
        }
    }
}
