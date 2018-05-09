using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            short estatura;
            long enteroLargo;
            float enteroComaFlotante;
            double enterDoble;
            int edad;

            uint enteroSinSigno;

            string saludo ="hola";
            bool verdad;

            verdad = true;

            edad = 18;
            estatura = 178;
            int resultado = Suma(edad, estatura);

            Console.Write.ine(resultado);

        }

        private static int Suma(int a, int b){
            return(a + b);
        }
    }
}
