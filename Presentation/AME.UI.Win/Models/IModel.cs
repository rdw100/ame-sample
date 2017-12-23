using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AME.UI.Win.Models;

namespace AME.UI.Win.Models
{
    // IModel interface, part of MVP design pattern. 
    public interface IModel
    {
        void AddMember(MemberModel member);
        void UpdateMember(MemberModel member);
        List<string> GetBrokenRules(MemberModel member);
    }
}
