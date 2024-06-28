using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ContactManagerApp.Attributes
{
    public class E164Phone : ValidationAttribute
    {
        private const string E164Pattern = @"^\+[1-9]\d{1,14}$";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string phoneNumber && Regex.IsMatch(phoneNumber, E164Pattern))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("The phone number must be in E.164 format.");
        }
    }
}
