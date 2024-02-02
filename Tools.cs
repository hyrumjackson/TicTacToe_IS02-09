using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_IS02_09
{
    internal class Tools
    {

        //Team 2:
        //Receive the “board” array from the driver class
        //Contain a method that prints the board based on the information passed to it
        //
        public static void PrintBoard(string[] boardArray)
        {
            Console.WriteLine();
            Console.WriteLine("  " + boardArray[0] + " | " + boardArray[1] + " | " + boardArray[2]);
            Console.WriteLine(" ---+---+--- ");
            Console.WriteLine("  " + boardArray[3] + " | " + boardArray[4] + " | " + boardArray[5]);
            Console.WriteLine(" ---+---+--- ");
            Console.WriteLine("  " + boardArray[6] + " | " + boardArray[7] + " | " + boardArray[8]);
            Console.WriteLine( );
        }
        //
        // Contain a method that receives the game board array as input and returns if there is a winner
        // and who it was
        /*      0 (game isn't over)
                1 (player 1 won)
                2 (player 2 won)
                3 (it's a tie)*/
        // player one is x
        // player two is o

        public static int DeclareWinner(string[] boardArray)
        {
            int winNum = 0;
            int letterCount = 0;
            string winnerChar = "";
            bool isWin = false;

            for (int i = 0; i < boardArray.Length; i++)
            {
                // Counts the x's and o's 
                if ((boardArray[i] == "x") || (boardArray[i] == "o"))
                {
                    letterCount++;
                }

                if (isWin == false) 
                {
                    // checks for any wins in the columns
                    if ((i == 0) || (i == 1) || (i == 2))
                    {

                        if ((boardArray[i] == boardArray[i + 3]) && (boardArray[i] == boardArray[i + 6]))
                        {
                            winnerChar = boardArray[i];
                            isWin = true;
                        }
                    }

                    // checks for any wins in the rows 
                    if ((i == 0) || (i == 3) || (i == 6))
                    {
                        if ((boardArray[i] == boardArray[i + 1]) && (boardArray[i] == boardArray[i + 2]))
                        {
                            winnerChar = boardArray[i];
                            isWin = true;
                        }
                    }

                    // checks for any wins diagonally
                    if ((i == 4))
                    {
                        if ((boardArray[i] == boardArray[i + 2]) && (boardArray[i] == boardArray[i - 2]))
                        {
                            winnerChar = boardArray[i];
                            isWin = true;
                        }

                        else if ((boardArray[i] == boardArray[i + 4]) && (boardArray[i] == boardArray[i - 4]))
                        {
                            winnerChar = boardArray[i];
                            isWin = true;
                        }
                    }
                }
                
            }

            if ((letterCount == 9) && (winnerChar == ""))
            {
                winNum = 3;
            }
            else if (winnerChar == "x")
            {
                winNum = 1;
            }

            else if (winnerChar == "o")
            {
                winNum = 2;
            }
            else
            {
                winNum = 0;
            }

            return winNum;
        }




        //Print Format
        //
        //  x | o | x
        // ---+---+---
        //  o | x | o
        // ---+---+---
        //  x | o | x
        //
        //Array Format
        //
        //  1 | 2 | 3
        // ---+---+---
        //  4 | 5 | 6
        // ---+---+---
        //  7 | 8 | 9
        //
        // [1, 2, 3, 4, 5, 6, 7, 8, 9]

    }
}
