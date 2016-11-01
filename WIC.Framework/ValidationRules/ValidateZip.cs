using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Framework.ValidationRules
{
    /// <summary>
    /// ZIP validation rule
    /// </summary>
    public class ValidateZip : ValidateRegex
    {
        public ValidateZip(string propertyName) :
            base(propertyName, @"^\d{5}(?:[-\s]\d{4})?$")
        {
            Error = propertyName + " is not a valid Zip code";
        }

        public ValidateZip(string propertyName, string errorMessage) :
            this(propertyName)
        {
            Error = errorMessage;
        }
    }
}
