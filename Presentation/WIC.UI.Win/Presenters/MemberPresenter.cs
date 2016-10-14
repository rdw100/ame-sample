using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WIC.UI.Win.Models;
using WIC.UI.Win.Views;

namespace WIC.UI.Win.Presenters
{
    /// <summary>
    /// Member Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class MemberPresenter : Presenter<IMemberView>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view</param>
        public MemberPresenter(IMemberView view)
            : base(view)
        {
        }

        /// <summary>
        /// Saves a member by getting view data and sending it to model.
        /// </summary>
        /// <returns>Number of records affected.</returns>
        public void Save()
        {
                var member = new MemberModel
                {                    
                    MemberName = View.MemberName,
                    Address = View.Address,
                    City = View.City,
                    State = View.State,
                    Zip = View.Zip,
                };

                Model.AddMember(member);     
        }
    }
}
