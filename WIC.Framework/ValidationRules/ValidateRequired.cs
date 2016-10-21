using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Framework.ValidationRules
{
    // represents a validation rules that states that a value is required

    public class ValidateRequired : ValidationRule
    {

        public ValidateRequired(string propertyName)
            : base(propertyName)
        {
            Error = propertyName + " is a required field.";
        }

        public ValidateRequired(string propertyName, string errorMessage)
            : base(propertyName)
        {
            Error = errorMessage;
        }

        public override bool Validate(ValidationObject businessObject)
        {
            try
            {
                return GetPropertyValue(businessObject).ToString().Length > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
