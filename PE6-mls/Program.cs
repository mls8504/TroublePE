// Name: Trouble Practice Exercise(s)
// Developed By: Megan Schier and Gabrielle Mark 
// Purpose: PE02, To declare attributes for the Trouble game and determine methods prior to programming. 
// Update: Created attributes and coded welcome/rules methods of output
// Update: PE06. By changing the start position of each piece, it makes each piece start at a different side of the board and changing the start position in general  
//         can change the game in terms of length. TryParse is used to convert a string into a different identifier, it cannot be used in this case as the name is a string so IsNullOrEmpty() 
//         is the ideal way to check a string. 
using System;

namespace PE4_mls
{
    class Program
    {
        static void Main(string[] args)
        {
            // attributes 
            //  Players
            string player1;
            string playerAge;
            string Ai1;
            string Ai2;
            string Ai3;


            // Dice 
            int diceRoll;  // 6 sided  


            // Colors 
            string color;  //( userInput for what color they want then is assigned) 
            string playerColor;

            // gameBoard  
            int boardSpace = 42;
            const int BOARD_START = 0;
            const int BOARD_END = 33;



            // playerPieces  
            int P1pos = 0;
            int P1new;
            int P2pos = 0;
            int P2new;
            int P3pos = 0;
            int P3new;
            int P4pos = 0;
            int P4new;

            /* Methods 
              Game rules  
              set up game
              turn order  - by die roll  
              roll dice  
              check if  leave  
               if (diceRoll == 6 || 0 ) { 
                  roll again 
                  currPos = diceRoll + 0; 
              } -- Only for first movement
              move Pieces 
                int startPos == 0; 
                int currPos
                int endPos
              repeat ( loops) 
              declare winner 
            */
            // Ask player to enter name 
            Console.WriteLine("Please enter a name for player: ");
            string playerName;
            playerName = Console.ReadLine();
            bool enteredName = string.IsNullOrEmpty(playerName);
            if (enteredName != false)
            {
                Console.WriteLine("No name was entered therefore your name is Player1");
                playerName = "Player1";
            }
            Console.WriteLine("\nPlease enter what color you want: (B)lue, (G)reen, (R)ed, (Y)ellow ");
            playerColor = Console.ReadLine();
            Console.WriteLine("\nPlease enter an age:  ");
            playerAge = Console.ReadLine();
            int age = 0;
            Boolean canParse = int.TryParse(playerAge, out age);
            if (canParse == false)
            {
                Console.WriteLine("No age entered, default age is 18\n");
                age = 18;
                playerAge = age.ToString();
            }
            // Welcome 
            Console.WriteLine("\t\t Welcome to Pop-O-Matic Trouble " + playerName + "(" + playerAge + ")" + "!");
            Console.WriteLine("\t\t _______________________________\n");
            playerAge = age.ToString();
            // Rules 
            Console.WriteLine("Rules: ");
            Console.WriteLine("--------");
            Console.WriteLine("\n To start, roll the die to see which player goes first, higher number wins." +
                " Everyone starts at “HOME” and must first roll a 6 to begin moving around the board." +
                " If a 6 is rolled the same person rolls again to move their piece." +
                " If two pieces end up on the same space, the piece that was already there gets bumped back to HOME, however, you cannot land on your own piece. " +
                "In order to win you must get all of your pieces around the board once and into the FINISH, you must roll and exact number to get into FINISH.");

            Console.WriteLine("\nGood Luck and Have Fun!");

            //Player Information 
            Console.WriteLine("\nPlayer Information: ");
            Console.WriteLine(" Player 1: " + playerName + "(" + playerAge + ")" + "     Piece Color: " + playerColor + "    Position: 0");
            Console.WriteLine(" AI Player: TroubleMaker1          Piece Color: Y       Position: 14");
            // Date and time output 
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("g"));

        }
    }
}

