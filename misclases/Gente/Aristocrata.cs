namespace misclases.Gente
{
    public class Aristocrata : persona
    {
        public Aristocrata(string nombre, string apellidos, int edad, Genero genero, string titulo) 
            : base(nombre, apellidos, edad, genero)
        {
            Titulo = titulo;
        }

        public string Titulo{ get; set; }

        public override string GetNombreCompleto()
        {
            return GetPretitulo() + " " + Titulo + " " + Nombre + " " + Apellidos;
        }

        public override string GetDatos()
        {
            return GetNombreCompleto() + " " + Edad + " " + Genero;
        }

        private string GetPretitulo()
        {
            if(Genero==Genero.Hombre)
            {
            return "Mr. ";
            }
            return "Lady ";
        }
    }
}