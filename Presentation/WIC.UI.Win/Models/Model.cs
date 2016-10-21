using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using WIC.Entities;
using WIC.Services;

namespace WIC.UI.Win.Models
{
    public class Model : IModel
    {
        static MemberService service = new MemberService();

        static Model()
        {
            Mapper.CreateMap<MemberModel, Member>();
        }

        // adds a new Member to the database.
        public void AddMember(MemberModel model)
        {
            var member = Mapper.Map<MemberModel, Member>(model);
            service.InsertMember(member);               
        }

        // updates an existing Member in the database.
        public void UpdateMember(MemberModel model)
        {
            var member = Mapper.Map<MemberModel, Member>(model);            
            service.UpdateMember(member);
        }

        /// <summary>
        /// Defining validation logic in the domain layer is ultimately desirable with overriding model preferrable.
        /// This issue has created MVP exstention libraries and numerous articles with competing styles.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public List<string> GetBrokenRules(MemberModel member)
        {
            List<string> brokenRules = new List<string>();

            var validateMember = Mapper.Map<MemberModel, Member>(member);
            if (!validateMember.IsValid())
            {
                brokenRules = validateMember.Errors; 
            }
            return brokenRules;
        }
    }
}
