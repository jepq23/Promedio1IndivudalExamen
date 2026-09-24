using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class EnemigoRango : EnemigosClase
    {
        private float balas;

        public EnemigoRango(float vida, float daño, string nombre, float balas)
        {
            this.vida = vida;
            this.daño = daño;
            this.nombre = nombre;
            this.balas = balas;
        }

        public override float CausarDaño()
        {
            if (balas > 0)
            {
                balas -= 1;
                return daño;
            }

            return 0;
        }
    }
}
