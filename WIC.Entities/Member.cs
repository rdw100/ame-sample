using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Entities
{
    /// <summary>
    /// Base class for member household members.
    /// </summary>
    public class Member
    {
        public int MemberId { set; get; }
        public string MemberName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //public Member (string name, string address, string city, string state, string zip)
        //{
        //    ID = Guid.NewGuid();
        //    Address = address;
        //    Name = name;
        //    City = city;
        //    State = state;
        //    Zip = zip;
        //}
    }
}
