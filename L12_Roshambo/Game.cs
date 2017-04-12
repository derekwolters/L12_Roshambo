using System;

///-----------------------------------------------------------------------------
///   Namespace:    L12_Roshambo
///   Description:  Play Rock, Paper, Scissors
///   Author:       Derek Wolters                
///   Date:         4.11.17
///-----------------------------------------------------------------------------

namespace L12_Roshambo
{
    class Game
    {
        static void Main(string[] args)
        {
            //instantiate varaibles that don't need to be reset
            bool keepGoing = true;
            Human Human = new Human();

            while (keepGoing)
            {
                //instantiate variables that need to be reset b/t each game
                int humanChoice = 0;
                int secondPlayerChoice = 0;           
                bool isMultiplayer = false;
            
                Console.WriteLine("Do you want to play against 1)Player 1 or" +
                                                                " 2)Player 2?");
                humanChoice = IntInputValidator.ValidateInput();

                //choose whom to play the game against
                if(humanChoice == 1)
                {
                    Rocky Rocky = new Rocky();
                    secondPlayerChoice = Rocky.generateRoshambo();
                }
                else if (humanChoice == 2)
                {
                    Bullwinkle Bullwinkle = new Bullwinkle();
                    secondPlayerChoice = Bullwinkle.generateRoshambo();
                }
                else
                {
                    Console.WriteLine("Multiplayer mode unlocked!!!");
                    isMultiplayer = true;
                    Human Human2 = new Human();
                    secondPlayerChoice = Human2.generateRoshambo("Player 2, ");
                }
                
                //get user's input        
                humanChoice = Human.generateRoshambo("Player 1, ");

                //compare the input
                CompareResults(humanChoice, secondPlayerChoice, isMultiplayer);

                Exit.ExitProgram();
            }            
        }
        
        //compare the results of the 2 player's inputs
        static void CompareResults (int choice1, int choice2, bool multiplayer)
        {
            //set default player ID return values
            string firstPlayerID = "You win!";
            string secondPlayerID = "Computer wins.";
            
            //output each player's choices
            if (multiplayer)
            {
                Console.WriteLine("Player 1 picked: " + (Roshambo)choice1);
                Console.WriteLine("Player 2 picked: " + (Roshambo)choice2);
                firstPlayerID = "Player 1 wins!";
                secondPlayerID = "Player 2 wins!";
            }
            else
            {
                Console.WriteLine("You picked: " + (Roshambo)choice1);
                Console.WriteLine("The computer picked: " + (Roshambo)choice2);
            }

            //output the winner of the game
            if (choice1 == (int)Roshambo.Rock && 
                    choice2 == (int)Roshambo.Rock)
            {                
                Console.WriteLine("Draw!");
            }
            else if (choice1 == (int)Roshambo.Rock && 
                        choice2 == (int)Roshambo.Paper)
            {
                Console.WriteLine(secondPlayerID);
            }
            else if (choice1 == (int)Roshambo.Rock && 
                        choice2 == (int)Roshambo.Scissors)
            {
                Console.WriteLine(firstPlayerID);
            }
            else if (choice1 == (int)Roshambo.Paper && 
                        choice2 == (int)Roshambo.Rock)
            {
                Console.WriteLine(firstPlayerID);
            }
            else if (choice1 == (int)Roshambo.Paper && 
                        choice2 == (int)Roshambo.Paper)
            {
                Console.WriteLine("Draw!");
            }
            else if (choice1 == (int)Roshambo.Paper && 
                        choice2 == (int)Roshambo.Scissors)
            {
                Console.WriteLine(secondPlayerID);
            }
            else if (choice1 == (int)Roshambo.Scissors && 
                        choice2 == (int)Roshambo.Rock)
            {
                Console.WriteLine(secondPlayerID);
            }
            else if (choice1 == (int)Roshambo.Scissors && 
                        choice2 == (int)Roshambo.Paper)
            {
                Console.WriteLine(firstPlayerID);
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }
    }
}
