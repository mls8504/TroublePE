// Name: Trouble Practice Exercise(s)
// Developed By: Megan Schier and Gabrielle Mark 
// Purpose: PE02, To declare attributes for the Trouble game and determine methods prior to programming. 
// Update: Created attributes and coded welcome/rules methods of output
// Update: PE08 We can not use the previously created Random because the second random roll needed is a different number than the first random used
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
            string firstPlayer;
            string secondPlayer;


            // Dice 
            int diceRoll;  // 6 sided  
            int p1Roll;
            int ai1roll;


            // Colors 
            string color;  //( userInput for what color they want then is assigned) 
            string playerColor;
            string randColor;

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
                Console.WriteLine("No name was entered, therefore your name is Player1");
                playerName = "Player1";
            }
            Console.WriteLine("\nPlease enter what color you want: (B)lue, (G)reen, (R)ed, (Y)ellow ");          
            playerColor = Console.ReadLine();
            bool selectedColor = string.IsNullOrEmpty(playerColor);
            if (selectedColor == true)
            {
                Random myrandom = new Random();
                int colorNum = myrandom.Next(4);
                if (colorNum == 1)
                {
                    randColor = "Blue";
                    Console.WriteLine("No color was selected, your color is set to " + randColor);
                    playerColor = randColor;
                }
                else if (colorNum == 2)
                {
                    randColor = "Green";
                    Console.WriteLine("No color was selected, your color is set to " + randColor);
                    playerColor = randColor;
                }
                else if (colorNum == 3)
                {
                    randColor = "Red";
                    Console.WriteLine("No color was selected, your color is set to " + randColor);
                    playerColor = randColor;

                }
                else if (colorNum == 4)
                {
                    randColor = "Yellow";
                    Console.WriteLine("No color was selected, your color is set to " + randColor);
                    playerColor = randColor;
                }
            }
            

            // Age input 
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
            // AI name input
            Console.WriteLine("\nPlease enter a name for the AI: ");
            string aiName;
            aiName = Console.ReadLine();
            bool computerName = string.IsNullOrEmpty(aiName);
            if (computerName != false)
            {
                Console.WriteLine("No name was entered, the AI will be named AI");
                aiName = "AI";
            }
            Console.WriteLine("\n\n");
            
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
            Console.WriteLine(" AI Player: " + aiName + "          Piece Color: Y       Position: 14");
            // Date and time output 
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("g"));

            // Initial roll for player order
            Console.WriteLine("A dice will now be rolled to determine who goes first");
            Random myRandom = new Random();
            diceRoll = myRandom.Next(1, 6);
            p1Roll = diceRoll;
            diceRoll = myRandom.Next(1, 6);
            ai1roll = diceRoll;
            Console.WriteLine(playerName + " rolled a " + p1Roll + "\t and " + aiName + " rolled a " + ai1roll);
            if ( p1Roll > ai1roll)
            { 
                Console.WriteLine(playerName + " goes first and " + aiName + " goes second");
                firstPlayer = playerName;
                secondPlayer = aiName; 
            } else if (p1Roll < ai1roll)
            {
                Console.WriteLine(aiName + " goes first then " + playerName + " goes second");
                firstPlayer = aiName;
                secondPlayer = playerName;
            } else if ( p1Roll == ai1roll)
            {
                Console.WriteLine(playerName + " goes first and " + aiName + " goes second");
                firstPlayer = playerName;
                secondPlayer = aiName; 
            } 
            // Actual Turn design 
            // Roll for a 6 to get out of start 
            // Roll again for movement if a 6 is rolled and update placement 
            // Compare placements
            // Next secondPlayer turn 
            // roll for a 6 for 2nd player 
            // roll for movement if a 6 is rolled and update placement 
            // Compare placements
            // Repeat player1 turn and player 2 ( loop and new methods)  turn until one meets winning conditions 
            // declare winner 
        }
    }
}

