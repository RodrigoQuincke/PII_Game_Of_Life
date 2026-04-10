using System;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        public bool[,] Matrix { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Board(bool[,] matrix, int width, int height)
        {
            
            this.Matrix = matrix;
            this.Width = width;
            this.Height = height;
        }
    }
}
