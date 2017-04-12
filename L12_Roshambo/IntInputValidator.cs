using System;

///-----------------------------------------------------------------------------
///   Namespace:    L12_Roshambo
///   Description:  get and validate a user's input
///   Author:       Derek Wolters                
///   Date:         4.11.17
///-----------------------------------------------------------------------------

namespace L12_Roshambo
{
    class IntInputValidator
    {        
        public static int ValidateInput()
        {
            int result;
            ConsoleKeyInfo UserInput = Console.ReadKey(true);
                        
            if (int.TryParse(UserInput.KeyChar.ToString(), out result) 
                && result > 0 
                && result <= 3)
            {
                Console.WriteLine();
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                return ValidateInput();
            }
        }
        
    }
}
