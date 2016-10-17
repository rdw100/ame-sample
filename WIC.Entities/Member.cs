using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Entities
{
    /// <summary>
    /// Household member class implements common elements from base class.  Cannot be inherited at this time.
    /// </summary>
    public sealed class Member : Person
    {
        public int MemberId { set; get; }
        public string MemberName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }        
    }
}
