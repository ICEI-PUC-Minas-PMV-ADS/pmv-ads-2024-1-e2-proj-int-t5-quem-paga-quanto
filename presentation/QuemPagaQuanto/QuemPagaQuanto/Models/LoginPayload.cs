using System.ComponentModel.DataAnnotations;

namespace QuemPagaQuanto.Models
{
    public class LoginPayload
    {
        [Required(ErrorMessage = "Obrigatório informar Email"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Senha"), DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
