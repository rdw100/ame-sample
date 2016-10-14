using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using WIC.Entities;

namespace WIC.Services.Contracts
{
    /// <summary>
    /// Defines contract for single Member interface.
    /// </summary>
    [ServiceContract]
    public interface IMemberService
    {
        [OperationContract]
        void InsertMember(Member member);

        [OperationContract]
        void UpdateMember(Member member);        
        
        //Member GetMemberById(Guid memberId);
    }
}
