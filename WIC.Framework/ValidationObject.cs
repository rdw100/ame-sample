using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AME.Framework.ValidationRules;

namespace AME.Framework
{
    // abstract validation object class
    // ** Enterprise Design Pattern: Domain Model

    public abstract class ValidationObject
    {
        // list of validation rules

        List<ValidationRule> rules = new List<ValidationRule>();

        // list of validation errors (following validation failure)

        List<string> errors = new List<string>();


        // gets list of validations errors

        public List<string> Errors
        {
            get { return errors; }
        }


        // adds a validation rule to the business object

        protected void AddRule(ValidationRule rule)
        {
            rules.Add(rule);
        }

        // determines whether validation rules are valid or not.
        // creates a list of validation errors when appropriate

        public bool IsValid()
        {
            bool valid = true;

            errors.Clear();

            foreach (var rule in rules)
            {
                if (!rule.Validate(this))
                {
                    valid = false;
                    errors.Add(rule.Error);
                }
            }
            return valid;
        }
    }
}
