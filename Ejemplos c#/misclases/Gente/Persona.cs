namespace misclases.Gente
{
    public enum Genero
    {
        Hombre,
        Mujer
    }

    public abstract class persona
    {
        public string Nombre { get; set ;}

        public string Apellidos { get; set ;}

        public int Edad { get; set ;}

        public Genero Genero { get; set ;}

        public persona(string nombre, string apellidos, int edad, Genero genero)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Genero = genero;
        }

        public abstract string GetNombreCompleto();

        public abstract string GetDatos();

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }
}     