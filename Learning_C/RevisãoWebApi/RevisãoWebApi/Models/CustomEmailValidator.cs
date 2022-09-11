using RevisaoWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisãoWebApi.Models
{
	public class CustomEmailValidator : ValidationAttribute
	{
		ContextDB dB = new ContextDB();
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				Usuario user = dB.usuarios.FirstOrDefault(x => x.Email == value.ToString());
				if (user == null)
				{
					return ValidationResult.Success;
				}
				else
					return new ValidationResult("E-mail já cadastrado!");
			}
			return new ValidationResult("O campo: " + validationContext.DisplayName
				+ "é um campo obrigatório."); //base.IsValid(value, validationContext);
		}
	}
}