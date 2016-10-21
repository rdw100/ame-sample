using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Framework.ValidationRules
{
    // abstract base class for input validation rules. 
    // maintains property name to which rule applies and validation error message

    public abstract class ValidationRule
    {
        public string Property { get; set; }
        public string Error { get; set; }

        public ValidationRule(string property)
        {
            Property = property;
            Error = property + " is not valid";
        }

        public ValidationRule(string property, string error)
            : this(property)
        {
            Error = error;
        }

        // validation method. To be implemented in derived classes

        public abstract bool Validate(ValidationObject validationObject);

        // gets value for given validation object's property using reflection

        protected object GetPropertyValue(ValidationObject validationObject)
        {
            // note: reflection is relatively slow
            return validationObject.GetType().GetProperty(Property).GetValue(validationObject, null);
        }
    }
}
