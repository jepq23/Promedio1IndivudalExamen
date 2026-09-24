using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class EnemigosClase
    {
        protected float vida;
        protected float daño;
        protected string nombre;

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
        }

        public virtual bool EstadoEnemigo()
        {
            return vida > 0;
        }
        public string ObtenerNombre()
        {
            return nombre;
        }

        public float ObtenerVida()
        {
            return vida;
        }
    }
}
