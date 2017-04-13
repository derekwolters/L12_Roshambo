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
            Rocky Rocky = new Rocky();
            Bullwinkle Bullwinkle = new Bullwinkle();
            string player2Name = "";

            Console.WriteLine("What is your name?");
            Human.name = Console.ReadLine();
            Console.WriteLine("Hi " + Human.name + "!");

            while (keepGoing)
            {
                //instantiate variables that need to be reset b/t each game
                int humanChoice = 0;
                int secondPlayerChoice = 0;           

                Console.WriteLine("Do you want to play against 1)" + 
                                    Rocky.name + " or " + "2)" + 
                                    Bullwinkle.name + "? (press 1 or 2)");
                humanChoice = IntInputValidator.ValidateInput();
               
                //choose whom to play the game against
                if(humanChoice == 1)
                {                   
                    secondPlayerChoice = Rocky.generateRoshambo();
                    player2Name = Rocky.name;
                }
                else if (humanChoice == 2)
                {                    
                    secondPlayerChoice = Bullwinkle.generateRoshambo();
                    player2Name = Bullwinkle.name;
                }
                else
                {
                    Console.WriteLine("Multiplayer mode unlocked!!!");                    
                    Human Human2 = new Human();
                    Console.WriteLine("What is your name Player 2?");

                    if (player2Name == "")
                    {
                        Human2.name = Console.ReadLine();
                        player2Name = Human2.name;
                    }
                    
                    secondPlayerChoice = Human2.generateRoshambo(player2Name);
                }
                
                //get user's input        
                humanChoice = Human.generateRoshambo(Human.name);

                //compare the input
                CompareResults(humanChoice, secondPlayerChoice, 
                                    Human.name, player2Name);

                Exit.ExitProgram();
            }            
        }
        
        //compare and output the results of the 2 player's inputs
        static void CompareResults (int c1, int c2,  string n1, string n2)
        {
            //output each player's choices
            Console.WriteLine(n1 + " picked: " + (Roshambo)c1);
            Console.WriteLine(n2 + " picked: " + (Roshambo)c2);                    

            //output the winner of the game
            if (c1 == c2)
            {
                Console.WriteLine("Draw!");
            }
            else if(
                (c1 == (int)Roshambo.Rock && c2 != (int)Roshambo.Paper) ||
                (c1 == (int)Roshambo.Paper && c2 != (int)Roshambo.Scissors) ||
                (c1 == (int)Roshambo.Scissors && c2 != (int)Roshambo.Rock)
                )
            { 
                Console.WriteLine(n1 + " wins!");
            }
            else
            {
                Console.WriteLine(n2 + " wins!");
            }
        }
    }
}
