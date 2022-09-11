using Locacao2ponto0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Locacao2ponto0.Controllers
{
	public class ControllerTipo : ApiController
	{
		private Locacao2ponto0Context db = new Locacao2ponto0Context();

		//Rota para Marca de carros
		[Route("Api/Veiculoes/MarcasCarros")] //Filtro
		[HttpGet]
		public IEnumerable<MarcaCarro> ObtemMarcasDosCarrosDisponiveis()
		{
			return db.MarcaCarroes;
		}

		//Rota para Marca de Motos
		[Route("Api/Veiculoes/MarcasMotos")] //Filtro
		[HttpGet]
		public IEnumerable<MarcaMoto> ObtemMarcasDasMotosDisponiveis()
		{
			return db.MarcaMotoes;
		}

		//Rota Para Modelo de Motos
		[Route("Api/Veiculoes/ModelosMotos")] //Filtro
		[HttpGet]
		public IEnumerable<ModeloMoto> ObtemModelosDasMotosDisponiveis(int pegaMarca)
		{
			return db.ModeloMotoes.Where(x => x.IdMarca == pegaMarca);
		}

		//Rota para Modelo 
		[Route("Api/Veiculoes/ModeloCarros")] //Filtro
		[HttpGet]
		public IEnumerable<ModeloCarro> ObtemModelosDosCarrosDisponiveis(int pegaMarca)
		{
			return db.ModeloCarroes.Where(x => x.IdMarca == pegaMarca);
		}
	}
}