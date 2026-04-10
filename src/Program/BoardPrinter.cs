using System;
using System.Text;

namespace Ucu.Poo.GameOfLife
{
    public class BoardPrinter
    {
        // SRP: Esta clase tiene una única responsabilidad: imprimir el tablero en la consola.
        // EXPERT: Es la clase experta en conocer cómo hay que representar el tablero e imprimirlo por consola.
        
        public void Print(Board board) // Recibe el tablero (Board).
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            
            // Usamos las dimensiones Width y Heigh que nos provee el tablero
            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    // Le preguntamos al tablero si la célula en esa posición está viva
                    if (board.GetCell(x, y).IsAlive) 
                    {
                        s.Append("|x|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
        }
    }
}