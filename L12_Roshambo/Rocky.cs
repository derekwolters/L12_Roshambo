using System;

namespace L12_Roshambo
{
    class Rocky : IPlayer
    {
        private string _playerName = "Rocky";

        public string name
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = "";
            }
        }

        public int generateRoshambo(string playerID)
        {
            int generatedChoice = 1;
            return generatedChoice;
        }
    }
}
