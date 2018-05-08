using System;

namespace Ambito
{
    public class Program
    {
        static int cantidad;
        static void Main(string[] args)
        {

            int edad;
            string saludo;
            long delatierraaLaLuna;

            var edad2 = 16;
            var otronumero = 4645313.0;
            var miSaludo = "hola";
            var LongitudGrande = 1890f;

            var miCantidad = SumaOResta(true);

            Console.WriteLine("Hello World!");
            Utils.EscribeConsola("Hola Mundo!!");
            Utils.EscribeConsola(Utils.Saludo("pepe"));


        }

        public void EscribeCantidad()
        {
            Utils.EscribeConsola(cantidad.ToString());
        }

        public int RestarUno()
            {
                return cantidad -= 1;
            }

        public int SumarDos()
        {
            int dos = 2;
            return cantidad += dos;
        }

        public static int SumaOResta(Boolean opcion)
        {
            var sumaesto = 15;
            if(opcion) // (if (opcion==true))
            {
                
                return cantidad += sumaesto;

            }
            return cantidad -= sumaesto;
        }
    }

    class Utils{
        public static void EscribeConsola(string salida){
            Console.WriteLine(salida);
        }

        public static string Saludo(string nombre){
            string Saludo = "Hola " + nombre;
            return Saludo;
        }

    }
}
