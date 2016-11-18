using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.Entities;
using WIC.Services;

namespace WIC.UI.Process
{
    /// <summary>
    /// User Process Components used to abstract tasks from the UI used as a Controllers.  Entities serve as a model.
    /// The UI serves as a view.
    /// </summary>
    public class MemberProcessComponent
    {
        /// <summary>
        /// Inserts a single member.
        /// </summary>
        /// <param name="member">A Member entity object.</param>
        public void InsertMember(Member member)
        {
            MemberService service = new MemberService();

            service.InsertMember(member);
        }

        /// <summary>
        /// Updates a single member.
        /// </summary>
        /// <param name="member">A Member entity object.</param>
        public void UpdateMember(Member member)
        {
            MemberService service = new MemberService();

            service.UpdateMember(member);
        }

        /// <summary>
        /// Deletes a single member.
        /// </summary>
        /// <param name="memberID">A Member entity object ID.</param>
        public void DeleteMember(int memberID)
        {
            MemberService service = new MemberService();

            service.DeleteMember(memberID);
        }

        /// <summary>
        /// Lists member objects.
        /// </summary>
        /// <returns>Returns a list of Members.</returns>
        public List<Member> ListMembers()
        {
            List<Member> result = default(List<Member>);
            MemberService service = new MemberService();

            result = service.ListMembers();
            return result;
        }

        /// <summary>
        /// Calls the GetMemberById operation method in the MemberService.
        /// </summary>
        /// <param name="memberID">A memberID value.</param>
        /// <returns>Returns a Member object.</returns>
        public Member GetMemberById(int memberID)
        {
            Member result = default(Member);
            MemberService service = new MemberService();

            result = service.GetMemberById(memberID);
            return result;
        }

        /// <summary>
        /// Describes available states.
        /// </summary>
        /// <returns>A set of named State constants.</returns>
        public static string[] GetStates()
        {
            return Enum.GetNames(typeof(State));
        }
    }
}
