using System;

namespace Day14_TicTacToe
{
    enum FieldEnum
    {
        Empty,
        X,
        O        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create the board using 2D array
            FieldEnum[,] board = new FieldEnum[3, 3];
            //current player variable, it will switch at the end of each turn
            FieldEnum currentPlayer = FieldEnum.X;
            //variable which will check whether the game is finished
            bool gameFinished = false;

            //rules for players

            //we should define players
            Console.Write("Player1, what is your name: ");
            string player1 = Console.ReadLine();
            Console.Write("Player2, what is your name: ");
            string player2 = Console.ReadLine();

            Console.WriteLine("Game begins!");

            //prepare the board
            PrintBoard(board);

            do
            {
                Console.WriteLine();
                Console.WriteLine($"Player's {currentPlayer} move!");

                //Gather user input for row and column
                Console.Write("Please input a row number: ");
                string rowInput = Console.ReadLine();
                Console.Write("Please input a column number: ");
                string columnInput = Console.ReadLine();

                //Special programmers exit with keyword STOP
                if (rowInput == "STOP" || columnInput == "STOP")
                {
                    Console.WriteLine("Game was ended by the master!");
                    break;
                }

                //Check if the user input is not empty
                if (string.IsNullOrEmpty(rowInput) || string.IsNullOrEmpty(columnInput))
                {
                    Console.WriteLine("Please don't input empty values!");
                    continue;
                }

                //Check if the user input is of data type int
                int row, column;
                bool isRowInputANumber = int.TryParse(rowInput, out row);
                bool isColumnInputANumber = int.TryParse(columnInput, out column);
                if (!isColumnInputANumber || !isRowInputANumber)
                {
                    Console.WriteLine("Please enter valid numbers!");
                    continue;
                }

                //Check if the user input is in the range of 1-3
                if (row > 3 || row < 1 || column > 3 || column < 1)
                {
                    Console.WriteLine("Please enter values in the range [1 - 3]!");
                    continue;
                }

                //Checking if the spot is empty
                if (board[row - 1, column - 1] != FieldEnum.Empty)
                {
                    Console.WriteLine("This field is taken, please choose another!");
                    continue;
                }

                //Making the move
                board[row - 1, column - 1] = currentPlayer;
                PrintBoard(board);

                //Change the current player to other. X -> O and O -> X
                currentPlayer = currentPlayer == FieldEnum.X ? FieldEnum.O : FieldEnum.X;

                gameFinished = IsGameFinished(board);
            } while (!gameFinished);
        }

        //Method will return true, if game is finished and will return false, if game is not finished.
        private static bool IsGameFinished(FieldEnum[,] board)
        {
            return false;
        }

        //Prints board
        private static void PrintBoard(FieldEnum[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {                    
                    switch (board[row, column])
                    {
                        case FieldEnum.Empty:
                            Console.ForegroundColor = ConsoleColor.Yellow; 
                            Console.Write("_ ");
                            break;
                        case FieldEnum.X:
                            Console.ForegroundColor = ConsoleColor.Red; 
                            Console.Write("X ");
                            break;
                        case FieldEnum.O:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("O ");
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}

//code trick:
//Change the current player to other. X -> O and O -> X
//if (currentPlayer == FieldEnum.X)
//{
//    currentPlayer = FieldEnum.O;
//}
//else
//{
//    currentPlayer = FieldEnum.X;
//}

////this is the same as above
//currentPlayer = currentPlayer == FieldEnum.X ? FieldEnum.O : FieldEnum.X;
