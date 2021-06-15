using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    class Program
    {

        static Board myBoard = new Board(8);  
        static void Main(string[] args)
        {
            //show the empty chess board
            printBoard(myBoard);


            //ask the user for an x and y coordinate we will place a piece
            Cell currentCell = setCurrentCell();
            currentCell.CurrentOccupied = true;


            //calculate all legal loves for that piece
            myBoard.MarkNextLegalMoves(currentCell, "Knight");


            //print the chess board. Use an x for occupied square. Use a + for legal move. Use . for empty cell.
            printBoard(myBoard);


            //wait for another enter key press before ending the program
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            //get x and y coordinate from the user and than return a cell location on the grid
            Console.WriteLine("Enter a current row number");
            int currentRow = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter a current column number");
            int currentColumn = int.Parse(Console.ReadLine());

            myBoard.theGrid[currentRow, currentColumn].CurrentOccupied = true;
            return myBoard.theGrid[currentRow, currentColumn];

        }

        private static void printBoard(Board myBoard)
        {
            //print the chess to the console. Use an x for piece location. Use a + for legal move. Use . for empty square.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentOccupied == true)
                    {
                        Console.Write("X");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else if (true)
                    {
                        Console.Write("."); 
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine("=======================================");

        }
    }
}
