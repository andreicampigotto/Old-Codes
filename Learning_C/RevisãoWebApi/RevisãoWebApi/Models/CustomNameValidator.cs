using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisãoWebApi.Models
{
	public class CustomNameValidator : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if(value != null)
			{
				if (value.ToString().Contains(" "))
				{
					return ValidationResult.Success;
				}
				else
					return new ValidationResult("Não Deu certo!");
			} 
			return new ValidationResult("O campo: " + validationContext.DisplayName 
				+ "é um campo obrigatório."); //base.IsValid(value, validationContext);
		}
	}
}