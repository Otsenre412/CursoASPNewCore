using System;
using misclases.Gente;

namespace misclases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Producto p = new Producto("0001", "Platanito");

            var p2 = new Producto("003", "Mora Negra", 0.05m);

            var p3 = new Producto("003", "Dentadura", 1);

            var p4 = new Producto("004", "Fresita", 0.5m);

            Console.WriteLine(p.GetDescripcionProducto());
            Console.WriteLine(p2.GetDescripcionProducto());
            Console.WriteLine(p3.GetDescripcionProducto());
            Console.WriteLine(p4.GetDescripcionProducto());

            var yo = new Plebeyo("Ernesto", "Gimenez", 25, Genero.Hombre, "Informatica");
            var tu = new Plebeyo("Alvaro", "Gimenez", 23, Genero.Hombre, "Informatica");
            var el = new Plebeyo("David", "Gimenez", 29, Genero.Hombre, "Fisio");

            var Señor = new Aristocrata("Ernesto", "Gimenez", 25, Genero.Hombre, "Señor");
            var Don = new Aristocrata("Alvaro", "Gimenez", 23, Genero.Hombre, "Don");
            var Puto = new Aristocrata("David", "Gimenez", 29, Genero.Hombre, "Puto");

            PrintDatos(yo);
            PrintDatos(Señor);
            PrintDatos(tu);
            PrintDatos(Don);
        }

        static void PrintDatos(persona p)
            {
                Console.WriteLine(p.GetDatos());
            }
    }
}
