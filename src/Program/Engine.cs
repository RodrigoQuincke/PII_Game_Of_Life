using System;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace Ucu.Poo.GameOfLife
{
    class Engine
    {
        public Board NewGeneration(Board board)
        {
            /* No es necesario utilizarlo, si se pasa como parametro el 
            bool[,] gameBoard = board.matriz;
            int boardWidth = board.width;
            int boardHeight = board.height;
            */

            bool[,] cloneBoard = new bool[board.Width, board.Height];

            for (int x = 0; x < board.Width; x++)
            {
                for (int y = 0; y < board.Height; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<board.Width && j>=0 && j < board.Height && board.Matrix[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(board.Matrix[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (board.Matrix[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneBoard[x,y] = false;
                    }
                    else if (board.Matrix[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneBoard[x,y] = false;
                    }
                    else if (!board.Matrix[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneBoard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneBoard[x,y] = board.Matrix[x,y];
                    }
                }
            }
            board.Matrix = cloneBoard;
            return board;
        }
        

    }
}
