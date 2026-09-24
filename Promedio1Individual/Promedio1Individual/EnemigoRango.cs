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

        public EnemigoRango(float vida, float daño, float balas)
        {
            this.vida = vida;
            this.daño = daño;
            this.balas = balas;
        }

        public override void RecibirDaño(float jugDaño)
        {
            vida -= jugDaño;
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

        public override bool EstadoEnemigo()
        {
            return vida > 0;
        }
    }
}
