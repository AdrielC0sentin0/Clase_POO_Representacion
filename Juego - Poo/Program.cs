using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Juego_Con_Poo.Properties;

namespace Juego_Con_Poo
{
    internal class Program
    {
        public static void Turnos(Jugador jugador, Random azar,Escalera escalera1, Escalera escalera2, Serpiente snake)
        {
            jugador.Avanza(jugador.Posicion + azar.Next(5) +1);
            Console.WriteLine("El JUGADOR: " + jugador.Nombre + " Esta en la posicion: " + jugador.Posicion);

            if (jugador.Posicion == escalera1.Pie)
            {
                jugador.Avanza(escalera1.Cabecera);
                Console.WriteLine("El JUGADOR: " + jugador.Nombre + " Cayo en la (Escalera 1), Avanza a: " + escalera1.Cabecera);
            }
            if (jugador.Posicion == escalera2.Pie)
            {
                jugador.Avanza(escalera2.Cabecera);
                Console.WriteLine("El JUGADOR: " + jugador.Nombre + " Cayo en la (Escalera 2), Avanza a: " + escalera2.Cabecera);
            }
            if (jugador.Posicion == snake.Cola)
            {
                jugador.Avanza(snake.Cola);
                Console.WriteLine("El JUGADOR: " + jugador.Nombre + " Cayo en una (Serpiente), Retrocede a: " + snake.Cola);
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string NombJ1, NombJ2;
            Jugador j1, j2;
            Random azar = new Random();

            Console.WriteLine("Ingresar El Nombre Del (JUGADOR 1): ");
                NombJ1 = Console.ReadLine();

            Console.WriteLine("Ingresar El Nombre Del (JUGADOR 2): ");
                NombJ2 = Console.ReadLine();

            j1 = new Jugador(NombJ1);
            j2 = new Jugador(NombJ2);

            Escalera escalera1 = new Escalera(7, 3);
            Escalera escalera2 = new Escalera(80, 6);
            Serpiente snake = new Serpiente(50, 2);

            do
            {
                Turnos (j1, azar, escalera1, escalera2, snake);
                Turnos (j2, azar, escalera1, escalera2, snake);

            } while (j1.Posicion < 100 && j2.Posicion < 100);

            if (j1.Posicion >= 100 || j2.Posicion >= 100)
            {
                if (j1.Posicion >= 100)
                {
                    Console.WriteLine("El JUGADOR " + j1.Nombre + " Es el GANADOR");
                }
                else if (j2.Posicion >= 100)
                {
                    Console.WriteLine("El JUGADOR " + j2.Nombre + " Es el GANADOR");
                }
            }
        }
    }
}
