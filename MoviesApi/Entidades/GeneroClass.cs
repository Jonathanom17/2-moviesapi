using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Entidades
{
    public class GeneroClass
    {
        [Required(ErrorMessage ="El {0} es requerido")]
        public required int Id { get; set; }
        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(20,ErrorMessage ="Máximo {1} cáracteres")]
        public required string Nombre { get; set; }

    }
}
