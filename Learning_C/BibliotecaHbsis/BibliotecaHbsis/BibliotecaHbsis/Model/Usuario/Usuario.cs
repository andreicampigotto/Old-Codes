using BibliotecaHbsis.Model.Padrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHbsis.Model.Usuario
{
	public class Usuario : Informacao
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
	}
}
