using IW7PP.Models.ProsthesisM;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IW7PP.Models.Cliente
{
    public class ClientesProtesicos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string PhoneNumber { get; set; }

<<<<<<< HEAD
        // Nueva propiedad para la meta de donaciones
        public double DonationGoal { get; set; }

        // Nueva propiedad para la meta de donaciones
        public double DonationStatus{ get; set; }

=======
>>>>>>> dd4246d5aaf16d5e50bee8b9cc5513e6243ce7c4
        // Conexion con protesis
        [ForeignKey("Prosthesis")]
        public int? ProtesisId { get; set; }

        // Conexion con estilo de vida
        [ForeignKey("LifeStyle")]
        public int LifeStyleId { get; set; }

        // Navegación
        public LifeStyle LifeStyle { get; set; }
        public Prosthesis Prosthesis { get; set; }

    }
}
