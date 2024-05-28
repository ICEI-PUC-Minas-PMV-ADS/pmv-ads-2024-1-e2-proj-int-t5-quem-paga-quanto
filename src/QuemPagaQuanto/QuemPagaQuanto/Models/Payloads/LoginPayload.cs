using System.ComponentModel.DataAnnotations;

namespace QuemPagaQuanto.Models.Payloads
{
    public class LoginPayload
    {
        [Required(ErrorMessage = "Informe seu email."), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe sua senha."), DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
