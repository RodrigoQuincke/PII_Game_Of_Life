using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    // EXPERT: Esta clase funciona como el centro de control del juego. 
    // SRP: Su única responsabilidad es coordinar el flujo principal: instanciar los objetos, cargar el tablero inicial y mantener el ciclo de juego.
    
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
                Engine.NewGeneration(boardMain);
                Thread.Sleep(300);
            }
        }
    }
}
