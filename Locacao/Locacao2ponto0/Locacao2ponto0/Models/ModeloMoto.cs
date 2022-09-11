using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class ModeloMoto : EBase
	{
		//Deixa default como N/A Para caso for bicicleta ou patinete
		public string NomeModeloMoto { get; set; } = PedeNomeModelo();

		[ForeignKey("IdMarca")]
		public MarcaMoto MarcaMoto { get; set; }
		public int IdMarca { get; set; }

		public static string PedeNomeModelo()
		{
			Locacao2ponto0Context db = new Locacao2ponto0Context();
			{

				foreach (var item in db.TipoDoVeiculoes.Select(x => x.Cod))
				{
					if (item < 2)
						return "Insira um Modelo";
					else
						return "N/A";

				}
				return "N/A";
			}
		}


	}
}