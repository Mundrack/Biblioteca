using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public string? EmailUser { get; set; }

        [Required]
        public bool EsAfiliado { get; set; }
    }
}
