using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.Data;
using WIC.Entities;

namespace WIC.Business
{
    public class MemberComponent
    {
        public void InsertMember(Member member)
        {
           
            // Data Access component declarations.
            var memberDAC = new MemberDAC();

            memberDAC.InsertMember(member);            
        }

        public void UpdateMember(Member member)
        {
            // Data Access component declarations.
            var memberDAC = new MemberDAC();

            memberDAC.UpdateMember(member);
        }

    }
}
