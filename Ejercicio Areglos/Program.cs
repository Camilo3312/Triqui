using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_Areglos
{
    class Program
    {
        static void Main(string[] args)
        {
            var game1 = new Board();
            var camilo = new Player(1, "Camilo", game1);
            var luis = new Player(2, "Luis", game1);

            var stch = true;
            while (!camilo.setWinner())
            {
                Console.Clear();
                Console.WriteLine(game1.VisualTable(game1.getTable()));

                if (stch)
                {
                    Console.WriteLine($"Turno de el jugador {camilo.username}");
                    var value = Convert.ToInt32(Console.ReadLine());

                    camilo.pushPositionToTable(value);
                    stch = !stch;
                }
                else
                {
                    Console.WriteLine($"Turno de el jugador {luis.username}");
                    var value = Convert.ToInt32(Console.ReadLine());
                    luis.pushPositionToTable(value);
                    stch = !stch;
                }
            }
            Console.Clear();
            Console.WriteLine(game1.VisualTable(game1.getTable()));
            Console.WriteLine($"{ game1.getWinner() } Has ganado!");

            Console.ReadLine();
        }

        
    }
}
