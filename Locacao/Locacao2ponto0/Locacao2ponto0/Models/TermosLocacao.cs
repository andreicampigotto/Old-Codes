using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class TermosLocacao : EBase
	{
		// se o termo de locação for aceito Seta True;
		public bool Ativo { get; set; } = false;
		public DateTime DataAlteracao { get; set; } = DateTime.Now;
		//é para caso o termo tenha sido salvo em TXT;
		public string CaminhoTermo { get; set; }
		//SAlva o termo no banco
		public string PersisteTermo { get; set; }
	}
}