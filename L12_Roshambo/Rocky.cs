using System;

namespace L12_Roshambo
{
    class Rocky : IPlayer
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
            int generatedChoice = 1;
            return generatedChoice;
        }
    }
}
