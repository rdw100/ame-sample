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
            MemberBusinessComponent bc = new MemberBusinessComponent();
            bc.InsertMember(member);
        }

        public void UpdateMember(Member member)
        {
            MemberBusinessComponent bc = new MemberBusinessComponent();
            bc.UpdateMember(member);
        }

        public List<Member> ListMembers()
        {
            List<Member> result = new List<Member>();
            MemberBusinessComponent bc = new MemberBusinessComponent();
            result = bc.ListMembers();
            return result;
        }

        /// <summary>
        /// Calls the GetMemberById business method of the MemberComponent.
        /// </summary>
        /// <param name="memberID"> A memberID value.</param>
        /// <returns>Returns a Member object.</returns>
        public Member GetMemberById(int memberID)
        {
            MemberBusinessComponent bc = new MemberBusinessComponent();
            return bc.GetMemberById(memberID);
        }

        public void DeleteMember(int memberID)
        {
            MemberBusinessComponent bc = new MemberBusinessComponent();
            bc.DeleteMember(memberID);
        }

    }
}
