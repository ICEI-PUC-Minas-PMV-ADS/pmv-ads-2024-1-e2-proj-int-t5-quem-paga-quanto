using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    public class UsuarioPayload : Usuario
    {
        [Required, Display(Name = "Confirmar Senha"), DataType(DataType.Password), Compare("Senha")]
        public string ConfirmarSenha { get; set; }
    }
}
