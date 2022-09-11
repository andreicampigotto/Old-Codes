using BibliotecaHbsis.Model.Padrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHbsis.Model.Livro
{
	public class Livro : Informacao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string Isbn { get; set; }
		public int Genero { get; set; }
		public int Editora { get; set; }
	}
}
