using System;

///-----------------------------------------------------------------------------
///   Namespace:    L12_Roshambo
///   Description:  Create a Player subclass that allows the user to choose a 
///                 tool to win
///   Author:       Derek Wolters                
///   Date:         4.11.17
///-----------------------------------------------------------------------------

namespace L12_Roshambo
{
    class Human : IPlayer
    {
        private string _playerName = "";

        public Human() {
                Console.WriteLine("What is your name?");
                _playerName = Console.ReadLine();            
        }

        public string name
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value;
            }
        }

        public int generateRoshambo(string playerID)
        {
            Console.WriteLine(playerID + ", choose your winning tool:");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            int generatedChoice = IntInputValidator.ValidateInput();
            return generatedChoice;
        }
    }
}
