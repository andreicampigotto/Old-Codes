using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	
	public class MarcaCarro : EBase
	{
		//Deixa default como N/A Para caso for bicicleta ou patinete


		public string NomeMarcaCarro { get; set; } = PedeNomeMarca();

		public static string PedeNomeMarca()
		{
			Locacao2ponto0Context db = new Locacao2ponto0Context();
			{
			
				foreach (var item in db.TipoDoVeiculoes.Select(x => x.Cod))
				{
					if (item <2 )
						return "Insira uma Modelo";
					else
						return "N/A";

				}
				return "N/A";
			}
		}
	}
}