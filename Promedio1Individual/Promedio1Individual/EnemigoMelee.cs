using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class EnemigoMelee : EnemigosClase
    {
        protected float Daño;

        public EnemigoMelee(float vida, float daño)
        {
            this.vida = vida;
            this.daño = daño;
        }

        public override void RecibirDaño(float jugDaño)
        {
            vida -= jugDaño;
        }

        public override float CausarDaño()
        {
            return Daño;
        }

        public override bool EstadoEnemigo()
        {
            return vida > 0;
        }
    }
}
