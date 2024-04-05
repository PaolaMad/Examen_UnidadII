using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examenUnidadII_backend.Entites
{
    [Table("tasks", Schema = "transactional")]
    public class ImcEntity
    {
        [Column("id")]
        [Key]
        public Guid id { get; set; }
        [Required]
        [StringLength(100)]
        [Column("nombre")]
        public string nombre { get; set; }
        [Required]
        [Column("genero")]
        public string genero { get; set; }
        [Required]
        [Column("peso")]
        public string peso { get; set; }
        [Required]
        [Column("altura")]
        public string altura { get; set; }
        [Required]
        [Column("imc")]
        public string imc { get; set; }
    }
}
