using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class Usuario
	{
		//Aqui Pega Id e todos os dados do usuario que esta logado..
		/*[ForeignKey("IdUsuarioLogado")]
		public UsuarioLogado UsuarioLogado{ get; set; }
		public int? IdUsuarioLogado { get; set; }*/

		//Esse Id é para teste na tabela de locação 
		[Key]
		public int Id { get; set; }

		[CustomValidFields(Enums.ValidFields.ValidaEmail)]
		public string Email { get; set; }

		//Parametros se a pessoas tem ou não alguma preferencia
		public bool Ativo { get; set; } = false;
		public bool TrabalhadorNoturno { get; set; } = false;
		public bool PDC { get; set; } = false;
		public bool FuncDeFora { get; set; } = false;
		public bool OfereceCarona { get; set; } = false;
		public DateTime VerificaIdoso { get; set; }


	}
}