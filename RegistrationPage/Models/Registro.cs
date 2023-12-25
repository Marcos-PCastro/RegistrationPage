using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationPage.Models
{
    public class Registro
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Title { get; set; }

        [DisplayName ("Concluído")]
        public bool Done { get; set; }

        [DisplayName ("Criado em")]
        public DateTime Created { get; set; } = DateTime.Now;

        [DisplayName ("Ultima Atualização")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        [DisplayName ("Usúario")]
        public string User { get; set; }
    }
}
