using System;

namespace Ucu.Poo.GameOfLife
{
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
