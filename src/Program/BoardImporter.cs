using System;
using System.IO;

namespace Ucu.Poo.GameOfLife
{
    // EXPERT: Es la clase experta en interpretar y transformar un archivo de texto externo en una matriz de booleanos que el sistema pueda entender.
    // SRP: Su única responsabilidad es la carga de datos. 
    
    public class BoardImporter
    {
        public Board FileReader()
        {
            string basePath = AppContext.BaseDirectory;
            string url = "board.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for ( int y=0 ; y < contentLines.Length; y++)
            {
                for ( int x=0 ; x < contentLines[y].Length; x++)
                {
                    if ( contentLines[y][x] == '1')
                    {
                        board[x,y] = true;
                    }
                }
            }
            Board boardMain = new Board(board);
            return boardMain;
        }
    }
}