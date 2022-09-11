using BibliotecaHbsis.Model.Padrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHbsis.Model.Autor
{
	public class Autor : Informacao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
	}
}
