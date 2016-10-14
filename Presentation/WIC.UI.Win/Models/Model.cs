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

        #region Member persistence

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

        #endregion
    }
}
