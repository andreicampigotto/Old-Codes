using RevisaoWebApi.Enums;
using RevisaoWebApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisãoWebApi.Models
{
	public class CustomValidFields : ValidationAttribute
	{
		ContextDB dB = new ContextDB();

		private ValidFilds typeField; //  = string.Empty;
		public CustomValidFields(ValidFilds type)
		{
			typeField = type;
		}
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				switch (typeField)
				{
					case ValidFilds.ValidaLogin:
						return ValidarLogin(value, validationContext.DisplayName);
					case ValidFilds.ValidaEmail:
						return ValidarEmail(value, validationContext.DisplayName);
					case ValidFilds.ValidaSenha:
						return ValidarSenha(value, validationContext.DisplayName);
					case ValidFilds.ValidaNome:
						return ValidarNome(value, validationContext.DisplayName);
					default:
						break;
				}
			}

			return new ValidationResult($"O Campo {validationContext.DisplayName} é obrigatório.");
		}
		private ValidationResult ValidarEmail(object value, string displayField)
		{
			var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

			if (result)
				return ValidationResult.Success;

			return new ValidationResult($"O Campo {displayField} é invalido");
		}

		private ValidationResult ValidarLogin(object value, string displayField)
		{
			var result = Regex.IsMatch(value.ToString(), @"^[a-zA-Z0-9]+$");

			/*if (result)
				return ValidationResult.Success;

			return new ValidationResult($"O Campo {displayField} é invalido");

			switch (typeField)
			{
				case "LoginSucess":
					{
						Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

						if (user != null)
							return ValidationResult.Success;
						else
							return new ValidationResult("Login invalido.");
					}
				case "SemValidacao":
					{
						return ValidationResult.Success;
					}
			}*/
			Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

			var login = value.ToString();

			if (login.Length >= 1 && result)
			{
				if (user == null && result)
					return ValidationResult.Success;

				else
					return new ValidationResult($"{displayField} já cadastrado.");
			}

			return new ValidationResult($"O campo {displayField} deve conter ao menos 1 caracter.");

		}
		private ValidationResult ValidarNome(object value, string displayField)
		{
			var result = Regex.IsMatch(value.ToString(), @"^[A-ZÀ-Ÿ] [A-zÀ-ÿ']+\s([A-zÀ-ÿ']\s?)*[A - ZÀ - Ÿ][A - zÀ - ÿ']+$");

			if (result == false)
				return ValidationResult.Success;

			return new ValidationResult($"O Campo {displayField} é invalido");
		}
		private ValidationResult ValidarSenha(object value, string displayField)
		{
			//var result = Regex.IsMatch(value.ToString(), @"^([a-zA-Z0-9]{8,50})$");
			var senha = value.ToString();
			if (senha.Length > 7)
				return ValidationResult.Success;
			else
				return new ValidationResult($"O campo {displayField} deve conter entre 8 e 50 caracteres");

		}
	}
}
