using System;

///-----------------------------------------------------------------------------
///   Namespace:    L12_Roshambo
///   Description:  Create Player subclass that picks a random tool to win
///   Author:       Derek Wolters                
///   Date:         4.11.17
///-----------------------------------------------------------------------------

namespace L12_Roshambo
{
    class Bullwinkle : IPlayer
    {
        private string _playerName = "Bullwinkle";

        public string name
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value ;
            }
        }

        public int generateRoshambo()
        {
            Random rnd = new Random();
            
            int generatedChoice = rnd.Next(1,4);
            return generatedChoice;
        }
    }
}
