using System.ComponentModel.DataAnnotations;

namespace QuemPagaQuanto.Models.Payloads
{
    public class UsuarioPayload : Usuario
    {
        [Required, Display(Name = "Confirmar Senha"), DataType(DataType.Password), Compare("Senha")]
        public string ConfirmarSenha { get; set; }
    }
}
