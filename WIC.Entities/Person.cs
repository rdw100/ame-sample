using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AME.Framework;

namespace AME.Entities
{
    /// <summary>
    /// Base class for all program participants: women, infants, and children.
    /// </summary>
    public abstract class Person : ValidationObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }               
    }
}
