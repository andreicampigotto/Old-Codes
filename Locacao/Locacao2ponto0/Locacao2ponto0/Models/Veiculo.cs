using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class Veiculo : EBase
	{
		[ForeignKey("IdTipoVeiculo")]
		public TipoDoVeiculo TipoDoVeiculo { get; set; }
		public int IdTipoVeiculo { get; set; }

		[CustomValidFields(Enums.ValidFields.ValidaPlaca)]
		public string Placa { get; set; } = "XXX-0800";

		[ForeignKey("IdModeloCarro")]
		public ModeloCarro ModeloCarro { get; set; }
		public int? IdModeloCarro { get; set; }

		[ForeignKey("IdModeloMoto")]
		public ModeloMoto ModeloMoto { get; set; }
		public int? IdModeloMoto { get; set; }

		[ForeignKey("IdCor")]
		public CorVeiculo CorVeiculo { get; set; }
		public int? IdCor { get; set; }

		public bool Ativo { get; set; } = false;

	}
}