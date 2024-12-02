using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Libros
    {
        [Key] //
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int IDLibros { get; set; }

        [Required(ErrorMessage ="Escriba el nombre")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Required(ErrorMessage ="¿En que fecha esta agregando este libro?")]
        public DateTime FechaAgregado { get; set; }

        [Required(ErrorMessage ="Por favor determine si es para afiliados")]
        public bool Afiliado { get; set; }
    }
}
