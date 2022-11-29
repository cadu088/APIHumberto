using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Aula01.Model
{
    public class UsuarioViewModel
    {
		[SwaggerSchema(ReadOnly = true)]
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]

		public string UserName { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(16, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
		public string Password { get; set; }
	}
}
