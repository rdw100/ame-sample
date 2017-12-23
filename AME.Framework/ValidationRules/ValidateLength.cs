using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AME.Framework.ValidationRules
{
    /// <summary>
    ///  Validates length.  Length must be between given min and max values
    /// </summary>
    public class ValidateLength : ValidationRule
    {
        private int _min;
        private int _max;

        public ValidateLength(string propertyName, int min, int max)
            : base(propertyName)
        {
            _min = min;
            _max = max;

            Error = propertyName + " must be between " + _min + " and " + _max + " characters long.";
        }

        public ValidateLength(string propertyName, string errorMessage, int min, int max)
            : this(propertyName, min, max)
        {
            Error = errorMessage;
        }

        public override bool Validate(ValidationObject validationObject)
        {
            int length = GetPropertyValue(validationObject).ToString().Length;
            return length >= _min && length <= _max;
        }
    }
}
