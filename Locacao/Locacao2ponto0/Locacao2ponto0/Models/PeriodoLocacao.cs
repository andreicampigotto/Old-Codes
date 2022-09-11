using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class PeriodoLocacao : EBase
	{
		//Datas para setar inicio e fim da vigência de locação
		public DateTime DataInicio { get; set; }
		public DateTime DataFim { get; set; }
	}
}