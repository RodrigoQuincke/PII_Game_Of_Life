using System;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    public class BoardImporter
    {
        public bool[,] FileReader()
        {
            string url = "board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for ( int y; y <= contentLines.Length; y++)
            {
                for ( int x; x <= contentLines[y].Length; x++)
                {
                    if ( contentLines[y][x] == 1)
                    {
                        board[x,y] = true;
                    }
                }
            }
            return board;
        }
    }
}