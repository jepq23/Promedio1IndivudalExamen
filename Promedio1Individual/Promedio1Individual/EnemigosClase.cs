using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class EnemigosClase
    {
        public float vida;
        public float daño;

        public EnemigosClase()
        {
        }

        public virtual float CausarDaño()
        {
            return daño;
        }

        public virtual void RecibirDaño(float jugDaño)
        {
            vida -= jugDaño;
            EstadoEnemigo();
        }

        public virtual bool EstadoEnemigo()
        {
            return vida > 0;
        }
    }
}
