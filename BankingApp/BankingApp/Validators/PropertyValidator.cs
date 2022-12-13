using System.ComponentModel.DataAnnotations;

namespace BankingApp.Validators
{
    public class PropertyValidator
    {
        public IList<ValidationResult> BankValidator(Object Model)
        {
            var result=new List<ValidationResult>();
            var validationContext = new ValidationContext(Model);
            Validator.TryValidateObject(Model, validationContext, result, true);
            if(Model is IValidatableObject)
            {
                //validation starts
                (Model as IValidatableObject).Validate(validationContext);
            }
                
            return result;
        }

    }
}
