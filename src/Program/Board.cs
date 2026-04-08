using System;

namespace Ucu.Poo.GameOfLife
{
    public class Board
    {
        BoardImporter fileReader = new BoardImporter();
        bool[,] board = fileReader.FileReader();
        int boardWidth = gameBoard.GetLength(0);
        int boardHeight = gameBoard.GetLength(1);
    }
}
