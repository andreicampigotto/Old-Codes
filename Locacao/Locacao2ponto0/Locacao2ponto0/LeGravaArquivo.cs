using Locacao2ponto0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Locacao2ponto0
{
	public class LeGravaArquivo
	{
		private Locacao2ponto0Context db = new Locacao2ponto0Context();
		public static string caminhoCSV = @"C:\Users\andre\Desktop\teste3.csv";

		/// <summary>
		/// Esse Método abre o arquivo CSV para gravar no banco
		/// </summary>
		/// <param name="caminho"> passar por aqui o caminho do arquivo para salvar no banco</param>
		public void LeArquivo(string caminhoCSV)
		{
			using (StreamReader rd = new StreamReader(caminhoCSV, Encoding.Default, true))
			{
				int count = 0; int bla = 0;
				string linha = null;
				string[] colunasseparada = null;
				List<Object> linhas = new List<Object>();

				// ler o conteudo da linha e add na list 
				while ((linha = rd.ReadLine()) != null)
				{
					colunasseparada = linha.Split(';');
					var usuario = new Usuario();
					count++;
					if (!Int32.TryParse(colunasseparada[1], out bla) && count < 2)
						continue; // pula para a próxima linha

					//Grava no banco
					usuario.Id = int.Parse(colunasseparada[0]);
					usuario.Email = colunasseparada[1];
					usuario.PDC = bool.Parse(colunasseparada[2]);
					usuario.TrabalhadorNoturno = bool.Parse(colunasseparada[3]);

					db.Usuarios.Add(usuario);
					db.SaveChanges();
				}
			}
		}
		/// <summary>
		/// Método para pegar um arquivo Salvo e salvar no banco os termos
		/// </summary>
		public static string caminhoTermo = @"C:\Users\andre\Desktop\Termo.txt";
		public void LeGravaTermo(string caminhoTermo)
		{
			var termo = File.ReadAllText(caminhoTermo);

			var termos = new TermosLocacao();
			termos.CaminhoTermo = caminhoTermo;

			termos.PersisteTermo = termo;

			db.TermosLocacaos.Add(termos);
			db.SaveChanges();

		}
	}
}