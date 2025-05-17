using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Con_Poo.Properties
{
    internal class Serpiente
    {
        public int Cabecera;
        public int Cola;

        public Serpiente(int cabecera, int cola)
        {
            Cabecera = cabecera;
            Cola = cola;
        }
        public void Mover(Jugador jugador)
        {
            jugador.Avanza(Cola);
        }
    }
}
