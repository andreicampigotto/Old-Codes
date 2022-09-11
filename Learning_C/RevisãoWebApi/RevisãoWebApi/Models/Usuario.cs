using RevisãoWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
	public class Usuario : UserControls
	{
		[Key]
		public int Id { get; set; }

		[CustomValidFields(Enums.ValidFilds.ValidaNome)]
		public string Nome { get; set; }

		[CustomValidFields((Enums.ValidFilds.ValidaEmail))]
		public string Email { get; set; }

		[CustomValidFields((Enums.ValidFilds.ValidaLogin))]
		public string Login { get; set; }

		[CustomValidFields((Enums.ValidFilds.ValidaSenha))]
		public string Senha { get; set; }
	}
	
}