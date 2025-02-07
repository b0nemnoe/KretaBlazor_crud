using Kreta.Desktop.Validation.ValidationRules;
using System.Globalization;
using System.Windows.Controls;

namespace Kreta.Desktop.Validation
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is not null && value is string)
            {
                string nameToValidate = (string)value;
                NameValidationRules nvr = new NameValidationRules(nameToValidate);
                if (nvr.IsNameShort)
                    return new ValidationResult(false, "A név túl rövid!");

            }
            return new ValidationResult(true, "");
        }
    }
}
