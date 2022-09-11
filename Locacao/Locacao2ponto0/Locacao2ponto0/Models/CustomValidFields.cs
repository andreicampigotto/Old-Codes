using Locacao2ponto0.Enums;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Locacao2ponto0.Models
{
	public class CustomValidFields : ValidationAttribute
	{

		Locacao2ponto0Context db = new Locacao2ponto0Context();

		private ValidFields typeField;

		public CustomValidFields(ValidFields type)
		{
			typeField = type; // inicializando as variáveis no construtor
		}
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			//if (value != null) //já valida para nenhum dos campus ser nulo
			switch (typeField)
			{
				case ValidFields.ValidaPlaca:
					{ return ValidaPlaca(value, validationContext.DisplayName); }
				case ValidFields.ValidaEmail:
					{ return ValidaEmail(value, validationContext.DisplayName); }

				default:
					break;

			}
			return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório");
		}

		/// <summary>
		/// Esse método serve para validar as placas padrão antigo e mercosul
		/// </summary>
		/// <param name="value"></param>
		/// <param name="displayField"></param>
		/// <returns>apenas deixa passar as placas validas</returns>
		private ValidationResult ValidaPlaca(object value, string displayField)
		{
			var result = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}\-\d{4}$") ||
				Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}\d{4}$") ||
				Regex.IsMatch(value.ToString(), @" ^[a-zA-Z]{3}\d{1}[a-zA-Z]{2}\d{1}$") ||
				Regex.IsMatch(value.ToString(), @" ^[a-zA-Z]{3}\d{1}[a-zA-Z]{1}\d{2}$");

			var exist = db.Veiculoes.Any(x => x.Placa == value.ToString());
			
			//placa Default para bicicleta ou patinete
			if (value.ToString() == "XXX-0800")
				exist = false;

			if (result && !exist)
			{
				return ValidationResult.Success;
			}
			return new ValidationResult($"Placa {displayField} é invalida, insira uma placa valida!");

		}

		/// <summary>
		/// Valida Email Para salvar no banco e usar no fim...
		/// </summary>
		/// <param name="value"></param>
		/// <param name="displayField"></param>
		/// <returns> resultado se o e-mail é valido </returns>
		private ValidationResult ValidaEmail(object value, string displayField)
		{
			var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

			if (result)
				return ValidationResult.Success;

			return new ValidationResult($"O campo {displayField} é inválido");
		}

	}
}