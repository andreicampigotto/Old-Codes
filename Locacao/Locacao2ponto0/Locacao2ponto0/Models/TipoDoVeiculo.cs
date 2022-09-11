using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class TipoDoVeiculo : EBase
	{
		public string TipoVeiculo { get; set; }
		public double ValorMesalidade { get; set; } =  0.00;
	}
}