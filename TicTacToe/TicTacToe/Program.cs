using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        class GameBoard
        {
            public char[] BoardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            
            /*
            public void DrawBoard()
            {
                
                Console.WriteLine();
                int i = 1;
                
                // draw the rows
                for(int row = 0; row < 3; row++)
                {
                    Console.WriteLine("     |       |       ");


                    for (int column = 0; column < 3; column++)
                    {
                        Console.Write(" {0} |", BoardPositions[i]);
                    }

                    Console.WriteLine("-----+-------+---------");
                }

            }
            */

            
            public void DisplayBoard()
            {
                //Console.WriteLine("--------------------------");
                Console.WriteLine("           |           |           ");
                Console.WriteLine("   {0}     |   {1}     |   {2}     ", BoardPositions[0], BoardPositions[1], 
                    BoardPositions[2]);
                Console.WriteLine("     |       |       ");
                Console.WriteLine("-----+-------+---------");
                Console.WriteLine("     |       |       ");
                Console.WriteLine(" {0}     |   {1}     |   {2} ", BoardPositions[3], BoardPositions[4],
                    BoardPositions[5]);
                Console.WriteLine("     |       |       ");
                Console.WriteLine("-----+-------+---------");
                Console.WriteLine("     |       |       ");
                Console.WriteLine(" {0}     |   {1}     |   {2} ", BoardPositions[6], BoardPositions[7],
                    BoardPositions[8]);
                Console.WriteLine("     |       |       ");
                Console.WriteLine("");
                //Console.WriteLine("--------------------------");
            }
         
        }

        static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.DisplayBoard();
            Console.ReadLine();
        }

    }

}
