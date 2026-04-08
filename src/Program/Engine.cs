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

            Board cloneBoard = new Board(); // pasar parametros para creacion, ancho y alto

            for (int x = 0; x < board.width; x++)
            {
                for (int y = 0; y < board.height; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<board.width && j>=0 && j < board.height && board.matriz[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(board.matriz[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (board.matriz[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneBoard.matriz[x,y] = false;
                    }
                    else if (board.matriz[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneBoard.matriz[x,y] = false;
                    }
                    else if (!board.matriz[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneBoard.matriz[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneBoard.matriz[x,y] = board.matriz[x,y];
                    }
                }
            }
            return board.matriz = cloneBoard.matriz;
        }
        

    }
}
