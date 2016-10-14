using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.Business;
using WIC.Entities;
using WIC.Services.Contracts;

namespace WIC.Services
{
    public class MemberService : IMemberService
    {       
        public void InsertMember(Member member)
        {
            MemberComponent bc = new MemberComponent();
            bc.InsertMember(member);
        }

        public void UpdateMember(Member member)
        {
            MemberComponent bc = new MemberComponent();
            bc.UpdateMember(member);
        }
    }
}
