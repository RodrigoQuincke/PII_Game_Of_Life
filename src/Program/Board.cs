using System;

namespace Ucu.Poo.GameOfLife
{
    // EXPERT: Se aplica el patrón expert ya que esta clase es la dueña de la matriz de datos. 
    // SRP: Su responsabilidad es representar el estado del tablero, proveyendo su ancho y largo a quien lo necesite.
    
    public class Board
    {
        public bool[,] Matrix { get; set; }
        public int Width
        {
            get { return Matrix.GetLength(0); }
        }
        public int Height
        {
            get { return Matrix.GetLength(1); }
        }
        public Board(bool[,] matrix)
        {
            Matrix = matrix;
        }
    }
}
