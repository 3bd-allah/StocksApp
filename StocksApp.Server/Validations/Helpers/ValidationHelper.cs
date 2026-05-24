using System.ComponentModel.DataAnnotations;

namespace StocksApp.Server.Validations.Helpers
{
    public static class ValidationHelper
    {
        public static void ModelValidation(object obj)
        {
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);

            if (!isValid) 
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);

        }
    }
}
