using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIC.Framework;
using WIC.Framework.ValidationRules;

namespace WIC.Entities
{
    /// <summary>
    /// Household member class implements common elements from base class.  Cannot be inherited at this time.
    /// </summary>
    public sealed class Member : Person
    {
        public Member()
        {
            // establish business rules

            AddRule(new ValidateRequired("FirstName"));
            AddRule(new ValidateLength("FirstName", 1, 40));

            AddRule(new ValidateRequired("LastName"));
            AddRule(new ValidateLength("LastName", 1, 40));

            AddRule(new ValidateRequired("Address"));
            AddRule(new ValidateLength("Address", 1, 35));

            AddRule(new ValidateRequired("City"));
            AddRule(new ValidateLength("City", 1, 15));

            AddRule(new ValidateRequired("State"));
            AddRule(new ValidateLength("State", 1, 2));

            AddRule(new ValidateRequired("Zip"));
            AddRule(new ValidateLength("Zip", 1, 5));
            //AddRule(new ValidateZip("Zip"));
        }
        public string City { get; set; }      
        public string State { get; set; }          
        public string Address { get; set; }
        public string Zip { get; set; }        
    }
}
