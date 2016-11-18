using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.Data;
using WIC.Entities;

namespace WIC.Business
{
    /// <summary>
    /// Member business logic component encapsulates the business logic and application state.
    /// Currently, responsible for coordinating and managing any transactions that may be required in the business layer. 
    /// </summary>
    /// <remarks>See Designing Business Components <a href="https://msdn.microsoft.com/en-us/library/ee658102.aspx">here</a></remarks>
    public class MemberBusinessComponent
    {
        /// <summary>
        /// Inserts member using data access.
        /// </summary>
        /// <param name="member"></param>
        public void InsertMember(Member member)
        {
            // Data Access component declarations.
            var memberDAC = new MemberDAC();
            memberDAC.InsertMember(member);
        }

        /// <summary>
        /// Updates member objects using data access.
        /// </summary>
        /// <param name="member"></param>
        public void UpdateMember(Member member)
        {
            // Data Access component declarations.
            var memberDAC = new MemberDAC();
            memberDAC.UpdateMember(member);
        }

        /// <summary>
        /// Deletes a single member object.
        /// </summary>
        /// <param name="memberID"></param>
        public void DeleteMember(int memberID)
        {
            // // Data Access component declarations.
            var memberDAC = new MemberDAC();
            memberDAC.DeleteMember(memberID);
        }      
        
        /// <summary>
        /// Lists member objects.
        /// </summary>
        /// <returns>Returns a list of Members.</returns>
        public List<Member> ListMembers()
        {
            List<Member> result = new List<Member>();

            // Data Access component declarations.
            var memberDAC = new MemberDAC();
            result = memberDAC.ListMembers();

            return result;
        }

        /// <summary>
        /// Returns a single member object.
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
        public Member GetMemberById(int memberID)
        {
            // Member result = new Member();
            Member result = default(Member);

            // Data Access component declarations.
            var memberDAC = new MemberDAC();
            result = memberDAC.GetMemberById(memberID);

            return result;
        }
    }
}
