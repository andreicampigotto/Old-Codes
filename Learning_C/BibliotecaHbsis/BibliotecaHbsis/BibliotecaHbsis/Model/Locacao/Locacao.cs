using BibliotecaHbsis.Model.Padrao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHbsis.Model.Locacao
{
	public class Locacao : Informacao
	{
		public int Id { get; set; }
		public int Usuario { get; set; }
		public int Tipo { get; set; }
		public DateTime Devolucao { get; set; } = DateTime.Now;
	}
}
