using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class Locacao : EBase
	{ 
		// Essa classe é a que o usuario gestor vai fazer as principais alterações
		public bool Termo { get; set; } = false;

		//usuario é setado como false para ficar "Em aprovação e quando esta aprovado é true"
		public bool Status { get; set; } = RetornaTermo();

		[ForeignKey("IdVeiculo")]
		public Veiculo Veiculo { get; set; }
		public int IdVeiculo { get; set; }

		[ForeignKey("IdUsuario")]
		public Usuario Usuario { get; set; }
		public int IdUsuario { get; set; }

		[ForeignKey("IdPeriodo")]
		public PeriodoLocacao PeriodoLocacao { get; set; }
		public int IdPeriodo { get; set; }


		public string RetornaStatus
		{
			get
			{
				if (Status)
					return "Vigente";
				else
					return "Pendente";
			}
		}

		public static bool RetornaTermo()
		{
			Locacao2ponto0Context db = new Locacao2ponto0Context();
			{
			//	var verificaTermoAceito = db.TermosLocacaos.Select(x => x.Ativo == true);

				foreach (var item in db.TermosLocacaos.Select(x => x.Ativo))
				{
					if (item)
						return true;
					else
						return false;

				}
				return false;
			}
		}

	}
}