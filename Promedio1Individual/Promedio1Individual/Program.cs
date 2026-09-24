using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1Individual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EnemigosClase> enemigos = new List<EnemigosClase>();


            float vidaJugador = 0;
            float dañoJugador = 0;
            

            bool repetir = true;

            while (repetir)
            {
                Console.WriteLine("Ingrese la vida del jugador (entre 0 a 100):");
                vidaJugador = float.Parse(Console.ReadLine());

                if (vidaJugador < 0 || vidaJugador > 100)
                {
                    Console.WriteLine("La vida del jugador debe estar entre 0 y 100");
                  
                }
                else
                {
                    repetir = false;
                }


            }

            repetir = true;

            while (repetir)
            {
                Console.WriteLine("Ingrese el daño del jugador (entre 0 a 100):");
                dañoJugador = float.Parse(Console.ReadLine());

                if (dañoJugador < 0 || dañoJugador > 100)
                {
                    Console.WriteLine("El daño del jugador debe estar entre 0 y 100");
                }
                else
                {
                    repetir = false;
                }
            }

            Jugador jugador = new Jugador(vidaJugador, dañoJugador);


            repetir = true;

            while (repetir)
            {
                Console.WriteLine("¿Qué enemigo crear 1: Melee, 2 Rango, 3 Fin");

                int op = int.Parse(Console.ReadLine());
                float EnemigoVida = 0;
                float EnemigoDaño = 0;
                int EnemigBalas = 0;

                if (op == 1)
                {
                    Console.WriteLine("Cuanta vida tendra?");
                    EnemigoVida = float.Parse(Console.ReadLine());

                    Console.WriteLine("Cuanto daño tendra?");
                    EnemigoDaño = float.Parse(Console.ReadLine());

                    enemigos.Add(new EnemigoMelee(EnemigoVida, EnemigoDaño, "Melee"));
                    Console.WriteLine("Enemigo Melee creado");
                }
                else if (op == 2)
                {
                    Console.WriteLine("Cuanta vida tendra?");
                    EnemigoVida = float.Parse(Console.ReadLine());

                    Console.WriteLine("Cuanto daño tendra?");
                    EnemigoDaño = float.Parse(Console.ReadLine());

                    Console.WriteLine("Cuantas balas tendra?");
                    EnemigBalas = int.Parse(Console.ReadLine());

                    enemigos.Add(new EnemigoRango(EnemigoVida, EnemigoDaño, "Rango", EnemigBalas));
                    Console.WriteLine("Enemigo Rango creado");
                }
                else if (op == 3)
                {
                    repetir = false;
                }
                else
                {
                    Console.WriteLine("Invalido");
                }

                

            }


            repetir = true;

            while (repetir)
            {
                if (enemigos.Count == 0)
                {
                    repetir = false;
                    Console.WriteLine("Todos los enemigos han sido derrotados");
                    return;
                }

                for (int i = 0; i < enemigos.Count; i++)
                {
                    int posEnemigo = i + 1;
                    EnemigosClase enemigo = enemigos[i];

                    Console.WriteLine(posEnemigo + " enemigo " + enemigo.ObtenerNombre());
                }

                Console.WriteLine("¿A qué enemigo deseas atacar?");
                int EnemElegido = int.Parse(Console.ReadLine());

                if (EnemElegido >= 1 && EnemElegido <= enemigos.Count)
                {
                    EnemigosClase enemigo= enemigos[EnemElegido - 1];

                    enemigo.RecibirDaño(dañoJugador);

                    Console.WriteLine("Enemigo le queda: " + enemigo.ObtenerVida());



                    if (enemigo.EstadoEnemigo() == false)
                    {
                        Console.WriteLine("El enemigo ha muerto");
                        enemigos.RemoveAt(EnemElegido - 1);
                    }

                    if (enemigos.Count == 0)
                    {
                        repetir = false;
                        Console.WriteLine("Todos los enemigos han sido derrotados");
                        return;
                    }


                    for (int i = 0; i < enemigos.Count; i++)
                    {
                        EnemigosClase enemigoAtaca = enemigos[i];
                        float dañoEnemigo = enemigoAtaca.CausarDaño();

                        if (dañoEnemigo > 0)
                        {
                            jugador.RecibirDano(dañoEnemigo);

                            Console.WriteLine(enemigoAtaca.ObtenerNombre() + " te hizo " + dañoEnemigo + " de daño");
                            Console.WriteLine("Tu vida: " + jugador.ObtenerVida());
                        }
                        else
                        {
                            Console.WriteLine(enemigoAtaca.ObtenerNombre() + " no puede atacar");
                        }

                        if (jugador.EstadoJugador() == false)
                        {
                            repetir = false;
                            Console.WriteLine("El jugador ha muerto");
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enemigo no existe");
                }
            }
        }
    }
}
