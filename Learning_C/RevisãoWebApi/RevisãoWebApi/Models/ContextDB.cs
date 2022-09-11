using RevisãoWebApi.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
	public class ContextDB : DbContext
	{
		public DbSet <Usuario> usuarios { get; set; }
	}
}