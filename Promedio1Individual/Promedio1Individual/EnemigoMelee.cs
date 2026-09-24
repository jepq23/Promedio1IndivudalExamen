using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class EnemigoMelee : EnemigosClase
    {
        public EnemigoMelee(float vida, float daño, string nombre)
        {
            this.vida = vida;
            this.daño = daño;
            this.nombre = nombre;
        }
    }
}
