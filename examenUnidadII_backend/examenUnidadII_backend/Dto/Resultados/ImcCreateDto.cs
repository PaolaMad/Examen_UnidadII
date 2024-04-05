using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace examenUnidadII_backend.Dto.Resultados
{
    public class ImcCreateDto
    {
        public string name { get; set; }
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
