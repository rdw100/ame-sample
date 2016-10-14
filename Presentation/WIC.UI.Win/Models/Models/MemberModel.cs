using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.UI.Win.Models
{
    public class MemberModel
    {
        public int MemberId { private set; get; }
        public string MemberName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //public MemberModel(string name, string address, string city, string state, string zip)
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
