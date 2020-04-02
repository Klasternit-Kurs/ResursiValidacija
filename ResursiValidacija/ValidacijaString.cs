using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ResursiValidacija
{
	class ValidacijaString : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			string vrednost = value as string;
			if (!(string.IsNullOrEmpty(vrednost) && string.IsNullOrWhiteSpace(vrednost)))
			{
				if (char.IsUpper(vrednost[0]))
					return ValidationResult.ValidResult;
				else
					return new ValidationResult(false, "Prvo slovo veliko");
			}
			return new ValidationResult(false, "Unesite nesto :(");
		}
	}
}
