using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ResursiValidacija
{
	public class ValidacijaBroja : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			if (int.TryParse(value.ToString(), out int br) && br >= 0 && br <= 10) 
			{
				return ValidationResult.ValidResult;
			}
			return new ValidationResult(false, "Ovo nije broj :(");
		}
	}
}
