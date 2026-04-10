using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardImporter importer = new BoardImporter();
            BoardPrinter print = new BoardPrinter();
            Board boardMain = importer.FileReader();
            while(true)
            {
                print.Print(boardMain);
                Thread.Sleep(300);
            }
        }
    }
}
