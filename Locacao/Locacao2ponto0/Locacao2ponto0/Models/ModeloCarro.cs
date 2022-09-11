using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class ModeloCarro : EBase
	{
		//Deixa default como N/A Para caso for bicicleta ou patinete
		public string NomeModeloCarro { get; set; } = PedeNomeModelo();

		[ForeignKey("IdMarca")]
		public MarcaCarro MarcaCarro { get; set; }
		public int IdMarca { get; set; }

		public static string PedeNomeModelo()
		{
			Locacao2ponto0Context db = new Locacao2ponto0Context();
			{

				foreach (var item in db.TipoDoVeiculoes.Select(x => x.Cod))
				{
					if (item < 2)
						return "Insira um modelo";
					else
						return "N/A";

				}
				return "N/A";
			}
		}

		//public virtual MarcaCarro MarcaCarro { get; set; }
	}
}