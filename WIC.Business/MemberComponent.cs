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
    public class MemberComponent
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

    }
}
