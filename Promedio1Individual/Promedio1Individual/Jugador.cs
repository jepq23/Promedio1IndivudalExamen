using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class Jugador
    {
        protected float vida;
        protected float dmg;

        public Jugador(float vida, float dmg)
        {
            this.vida = vida;
            this.dmg = dmg;
        }
        public virtual float RecibirDano(float dmgRecibido)
        {
            return vida - dmgRecibido;
        }
        public virtual float AtaqueDMG(float dmg)
        {
            return dmg;
        }

        public virtual float ObtenerVida()
        {
            return vida;
        }

        public virtual bool EstadoJugador()
        {
            return vida > 0;
        }
    }
}
