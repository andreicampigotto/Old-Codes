using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Locacao2ponto0.Models
{
    public class Locacao2ponto0Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Locacao2ponto0Context() : base("name=Locacao2ponto0Context")
        {
        }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.CorVeiculo> CorVeiculoes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.TipoDoVeiculo> TipoDoVeiculoes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.MarcaCarro> MarcaCarroes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.MarcaMoto> MarcaMotoes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.ModeloCarro> ModeloCarroes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.ModeloMoto> ModeloMotoes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.Veiculo> Veiculoes { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.Locacao> Locacaos { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.Usuario> Usuarios { get; set; }

		public System.Data.Entity.DbSet<Locacao2ponto0.Models.TermosLocacao> TermosLocacaos { get; set; }
	}
}
