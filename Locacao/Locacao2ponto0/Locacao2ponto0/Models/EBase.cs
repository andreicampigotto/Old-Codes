using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	//Classe base para geração de Id e Codigo
	public class EBase
	{
		[Key]
		public int Id { get; set; }
		public int Cod { get; set; }

	}
}