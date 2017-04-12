///-----------------------------------------------------------------------------
///   Namespace:    L12_Roshambo
///   Description:  Create the player interface
///   Author:       Derek Wolters                
///   Date:         4.11.17
///-----------------------------------------------------------------------------

namespace L12_Roshambo
{
    interface IPlayer
    {
        string name
        {
            get;
            set;
        }

        int roshamboValue
        {
            get;            
        }

        int generateRoshambo();
    }
}
