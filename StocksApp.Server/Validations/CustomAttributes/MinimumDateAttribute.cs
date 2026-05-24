using Microsoft.Extensions.Validation;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Server.Validations.CustomAttributes
{
    public class MinimumDateAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate ; 
        public MinimumDateAttribute(string minDate)
        {
            this._minDate = Convert.ToDateTime(minDate);
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is DateTime enteredDate)
            {
                if(enteredDate >= _minDate)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"{enteredDate} should be newer than {_minDate}");
                }
            }
            else
            {
                return null;
            }

            
        }
    }
}
