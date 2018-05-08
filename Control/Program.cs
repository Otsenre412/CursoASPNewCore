using System;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Sentencias de control del lenguaje

            //If else

            Console.WriteLine("Pulsa una tecla...");

            var a = Console.ReadKey();

            var teclaPulsada = a.KeyChar;

            if(teclaPulsada == '5')
            {
                Console.WriteLine("Has pulsado 5");
            }
            else if(teclaPulsada=='8')
            {
                Console.WriteLine("Has pulado el poderoso 8");
            }
            else
            {
                Console.WriteLine("No tienes ni idea de lo que has pulsado melon!!");
            }

            // switch

            switch(teclaPulsada)
            {
                case 'a':
                    Console.WriteLine("Añadir elemento");
                    break;
                case 'e':
                    Console.WriteLine("Eliminar elemento");
                    break;
                case 'l':
                    Console.WriteLine("Listar elementos");
                    break;
                default:
                    break;
            }

            // Iteraciones

            // while y bucle do while

            int i = 0;
            while(i < 5)
            {
                Console.WriteLine(i++);
            }

            // do while

            int x = 0;
            do
            {
                Console.WriteLine(x++);
            }
            while(x < 7);

            // for 
            Console.WriteLine("Ejecutando bucle for!");
            for(int b = 0; b < 10; b++)
            {
                Console.WriteLine(b);
            }

            Console.ReadKey();
        }
    }
}
