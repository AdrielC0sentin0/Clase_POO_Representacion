using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Con_Poo.Properties
{
    internal class Jugador
    {
        public string Nombre;
        public int Posicion;

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Posicion = 0;
        }
        public void Avanza(int posicionfinal)
        {
            Posicion = posicionfinal;
        }
    }
}
