using System;
using Lab08;

namespace Lab08.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new FountainOfObjectsGame(5, 5, new Location(0, 0));
            game.Map.SetRoomTypeAtLocation(new Location(0, 0), RoomType.Entrance);
            game.Map.SetRoomTypeAtLocation(new Location(2, 2), RoomType.Fountain);
            game.AddMonster(new Maelstrom(new Location(1, 1)));
            game.AddMonster(new Amarok(new Location(3, 3)));
            game.AddMonster(new Goblin(new Location(4, 4)));

            

            Console.WriteLine("Welcome to the Fountain of Objects");
            while (game.Player.Health > 0)
            {
                Console.WriteLine($"You are at {game.Player.Location}");
                game.EncounterMonsters();

                Console.WriteLine($"Enter command (move, quit): ");
                var command = Console.ReadLine();
                if (command == "quit") break;

                if (command == "move")
                {
                    Console.WriteLine("Enter direction (up, down, left, right): ");
                    var direction = Console.ReadLine();
                    game.Player.Move(direction);
                }
            }
            Console.WriteLine("Game over");
        }
    }
}