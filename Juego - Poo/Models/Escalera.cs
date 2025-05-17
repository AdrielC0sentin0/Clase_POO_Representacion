using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Con_Poo.Properties
{
    internal class Escalera
    {
        public int Cabecera;
        public int Pie;

        public Escalera(int cabecera, int pie)
        {
            Cabecera = cabecera;
            Pie = pie;
        }
        public void Mover(Jugador jugador)
        {
            jugador.Avanza(Cabecera);
        }
    }
}
