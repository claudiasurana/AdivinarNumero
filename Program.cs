using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class AdivinarNumero
    {
        static void Main(string[] args)
        {
            AdivinarNumero adivinarNumero = new AdivinarNumero();
            adivinarNumero.NumeroRandom();
        }

        public void NumeroRandom()
        {
            //Se genera un numero aleatorio entre 0 y 100. Debe acertarse en 4 intentos maximo

            Random random = new Random();
            int numeroRandom = random.Next(0, 101);
            int intentos = 4;
            int numeroIntroducido;

            Console.WriteLine("Adivina el numero generado aleatoriamente entre 0 y 100");

            while(intentos > 0)
            {
                Console.WriteLine($"Introduce un numero, tienes {intentos} intentos ¡Suerte!");

                if (int.TryParse (Console.ReadLine(), out numeroIntroducido))
                {

                    if (numeroIntroducido > 100 || numeroIntroducido < 0)
                    {
                        Console.WriteLine("Introduccion no valida. Debes introducir un numero entero entre 0 y 100 para acertar");
                    }
                    else
                    {
                        if (numeroIntroducido == numeroRandom)
                        {
                            Console.WriteLine($"¡Enhorabuena! El numero aleatorio es {numeroIntroducido}");

                            Console.WriteLine("Introduce 1 para volver a jugar u otro caracter para salir");
                            string onoff1 = Console.ReadLine();
                            if (onoff1 == "1")
                            {
                                NumeroRandom();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (numeroIntroducido < numeroRandom)
                        {
                            Console.WriteLine($"El numero aleatorio es mayor que {numeroIntroducido}");
                        }
                        else
                        {
                            Console.WriteLine($"El numero aleatorio es menor que {numeroIntroducido}");
                        }

                        intentos--;
                    }
                }
                else
                {
                    Console.WriteLine("Introduccion no valida. Debes introducir un numero entero entre 0 y 100 para acertar");
                }                
            }

            Console.WriteLine($"Has fallado. El numero era {numeroRandom}. No te preocupes, esta dificil");

            Console.WriteLine("Introduce 1 para volver a jugar u otro caracter para salir");
            string onoff2 = Console.ReadLine();
            if (onoff2 == "1")
            {
                NumeroRandom();
            }
            else
            {
                return;
            }
        }
    }
}
