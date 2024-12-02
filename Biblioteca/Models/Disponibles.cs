namespace Biblioteca.Models
{
    public class Disponibles
    {
        private List<Libros> libros;
        public Disponibles()
        {
            libros = new List<Libros>();
        }

        public List<Libros> ObtenerLibrosParaUsuario(Usuario usuario)
        {
            if (usuario.EsAfiliado)
            {
                return Libros;
            }
            else 
            {
                return Libros.Were
            }

        }
    }
}
