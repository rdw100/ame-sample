using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Entities
{
    /// <summary>
    /// Base class for all program participants: women, infants, and children.
    /// </summary>
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }               
    }
}
