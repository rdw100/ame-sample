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
    /// MV Patterns: MVP design pattern - Supervising Controller.
    /// </remarks>
    public class MemberPresenter : Presenter<IMemberView>
    {
        private IMemberView mView;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="view">The view</param>
        public MemberPresenter(IMemberView view)
            : base(view)
        {
            mView = view;
            Initialize();
        }

        /// <summary>
        /// Initialize presenter
        /// </summary>
        private void Initialize()
        {
            // Subscribe to save event.
            mView.Save += new EventHandler<EventArgs>(mView_Save);
        }

        /// <summary>
        /// Saves a member by getting view data and sending it to model.
        /// </summary>
        /// <returns>Number of records affected.</returns>
        private void mView_Save(object sender, EventArgs e)
        {
            MemberModel member = InitModel();
            try
            {
                if (View.IsValid)
                {
                    Model.AddMember(member);
                }
                //else
                //{
                //    View.IsValid = false;
                //}
            }
            catch (Exception ex)
            {
                View.ShowMessage(ex.Message);
            }
        }
        
        /// <summary>
        /// Determines whether the Member object passes validation rules.
        /// </summary>
        public void isValidMember()
        {
            MemberModel member = InitModel();

            if (Model.GetBrokenRules(member).Count() == 0)
            {
                View.IsValid = true;
            }
            else
            {
                View.IsValid = false;
                List<string> brokenRules = Model.GetBrokenRules(member);
                foreach (string item in brokenRules)
                {
                    View.ShowMessage(item);
                }                
            }
        }

        /// <summary>
        /// Initializes model values using view.
        /// </summary>
        /// <returns></returns>
        private MemberModel InitModel()
        {
            return new MemberModel
            {
                MemberName = View.MemberName,
                Address = View.Address,
                City = View.City,
                State = View.State,
                Zip = View.Zip,
            };
        }
    }
}
