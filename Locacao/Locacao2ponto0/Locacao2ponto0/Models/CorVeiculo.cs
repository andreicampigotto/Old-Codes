using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	//Classe que se usa para salvas e ultilizar as cores dos veiculos
	public class CorVeiculo : EBase
	{
		//Deixa default como N/A Para caso for bicicleta ou patinete
		public string NomeCorVeiculo { get; set; } = "N/A";
	}
	
}