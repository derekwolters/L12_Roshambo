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
        private string _player { get; set; }
        private int generatedChoice { get; }
        public string name
        {
            get
            {
                return _player;
            }
            set
            {
                _player = value;
            }
        }

        public int roshamboValue
        {
            get
            {
                return generatedChoice;
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
