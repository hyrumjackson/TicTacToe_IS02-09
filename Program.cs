using System.Dynamic;
using TicTacToe_IS02_09;
using static System.Runtime.InteropServices.JavaScript.JSType;

Tools t = new Tools();


//Declare variables
string player1 = "";
string player2 = "";
string userInput = "";
bool goodInput = false;
bool[] alreadyGuessed = { false, false, false, false, false, false, false, false, false };
int playerPlacement = 0;
int whoseTurn = 1;
int turnNum = 0;                                                                //DELETE LATER
int whoWins = 0;

//Create a game board array to store the players’ choices
string[] boardArray = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

//Welcome the user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine();
Console.WriteLine("Who will be player 1? (Playing as X)");
player1 = Console.ReadLine();
Console.WriteLine("Who will be player 2? (Playing as O)");
player2 = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("The board format is shown below. You will enter a number each turn.");
Console.WriteLine();
Console.WriteLine("  1 | 2 | 3");
Console.WriteLine(" ---+---+---");
Console.WriteLine("  4 | 5 | 6");
Console.WriteLine(" ---+---+---");
Console.WriteLine("  7 | 8 | 9");
Console.WriteLine();

//Ask each player in turn for their choice and update the game board array
while(whoWins == 0)
{
    turnNum++;                                                              //DELETE LATER

    if(whoseTurn == 1)
    {
        Console.WriteLine(player1 + ", where would you like to place an X?");
        
    }
    else
    {
        Console.WriteLine(player2 + ", where would you like to place an O?");
    }

    //Ask the user for a number, and check if it's valid
    do
    {
        userInput = Console.ReadLine();

        //Check if it's a number
        if(!int.TryParse(userInput, out playerPlacement))
        {
            Console.WriteLine("That is not a number, please try again:");
        }
        else
        {
            playerPlacement = int.Parse(userInput);

            //Check if it's in the valid range
            if(playerPlacement <= 0 || playerPlacement >= 10)
            {
                Console.WriteLine("That is not a valid number, please try again:");
            }
            else
            {
                //Check if it has already been guessed
                if(alreadyGuessed[playerPlacement - 1])
                {
                    Console.WriteLine("That square is taken, please try again:");
                }
                else
                {
                    goodInput = true;
                    alreadyGuessed[playerPlacement - 1] = true;
                }
            }
        }

    } while (!goodInput);

    //Mark the player's square
    if(whoseTurn == 1)
    {
        boardArray[playerPlacement - 1] = "x";
    }
    else
    {
        boardArray[playerPlacement - 1] = "o";
    }

    //Print the board by calling the method in the Tools class
    //t.PrintBoard(boardArray);
    Console.WriteLine("Board printed");                                         //DELETE LATER

    //Next player
    if (whoseTurn == 1)
    {
        whoseTurn--;

    }
    else
    {
        whoseTurn++;
    }

    //Reset goodInput
    goodInput = false;

    //Check for a winner by calling the method in the Tools class
    //whoWins = t.DeclareWinner(boardArray);
    Console.WriteLine("Winner checked");                                        //DELETE LATER
    
    if (turnNum == 9)                                                           //DELETE LATER
    {
        whoWins = 3;
    }
}

//Notify the players when a win has occurred and which player won the game
if(whoWins == 1)
{
    Console.WriteLine(player1 + " won the game!");
}
else if(whoWins == 2)
{
    Console.WriteLine(player2 + " won the game!");
}
else
{
    Console.WriteLine("Cat's game!");
}

Console.WriteLine("Thanks for playing!");