using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureRPG_Classes;

namespace AdventureRPG_Classes.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Dylan";
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Gold = 10;
            CurrentPlayer.Level = 1;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 20;
            CurrentPlayer.Armor = 0;
        }
    }
}

/*
using System;
using AdventureRPG_Classes;

namespace AdventureRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStart();
            Console.WriteLine("done");
            
            Console.ReadLine();
        }

        private static void GameStart()
        {
            Console.WriteLine("Enter 1 to start a new game or 2 to load a saved game!");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    StartANewGame();
                    break;
                case "2":
                    LoadGame();
                    break;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    break;
            }
        }

        public static void StartANewGame()
        {
            Console.WriteLine("Please enter a character name:");
            string playerName = Console.ReadLine();
            if (string.IsNullOrEmpty(playerName) || IsInputAString())
            {
                Console.WriteLine("Name cannot be empty, please enter a name for your character!");
            }
            Player player = new Player(playerName);
        }

        private static void LoadGame()
        {

        }

        private static void SaveGame()
        {

        }

        private static bool IsInputAString()
        {
            var input = Console.ReadLine();
            var isNumeric = int.TryParse(input, out int n);

            if (isNumeric)
            {
                Console.WriteLine("Please only use letters!");
            }

            return true;
        }
    }
}

 */
