using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AME.Business;
using AME.Entities;
using AME.Services.Contracts;

namespace AME.Services
{
    public class MemberService : IMemberService
    {
        /// <summary>
        /// Inserts a single member.
        /// </summary>
        /// <param name="member">A Member entity object.</param>    
        public void InsertMember(Member member)
        {
            MemberBusinessComponent bc = new MemberBusinessComponent();
            bc.InsertMember(member);
        }

        /// <summary>
        /// Updates a single member.
        /// </summary>
        /// <param name="member">A Member entity object.</param>
        public void UpdateMember(Member member)
        {
            MemberBusinessComponent bc = new MemberBusinessComponent();
            bc.UpdateMember(member);
        }

        /// <summary>
        /// Deletes a single member.
        /// </summary>
        /// <param name="memberID">A Member entity object ID.</param>
        public void DeleteMember(int memberID)
        {
            MemberBusinessComponent bc = new MemberBusinessComponent();
            bc.DeleteMember(memberID);
        }

        /// <summary>
        /// Lists member objects.
        /// </summary>
        /// <returns>Returns a list of Members.</returns>
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

    }
}
