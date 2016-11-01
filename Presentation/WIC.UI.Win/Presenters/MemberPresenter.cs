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
    /// MV Patterns: MVP design pattern - Passive View.  With Passive view, the View does no actively update itself.
    /// This pattern allows for the presenter to be testing in isolation from the UI by mocking the view.
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
            Model model = new Model();
            MemberModel member = InitModel(mView);
            try
            {
                if (mView.IsValid)
                {
                    model.AddMember(member);
                }
            }
            catch (Exception ex)
            {
                mView.ShowMessage(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether the Member object passes validation rules.
        /// </summary>
        public void isValidMember()
        {
            Model model = new Model();
            MemberModel member = InitModel(mView);

            if (model.GetBrokenRules(member).Count() == 0)
            {
                mView.IsValid = true;
            }
            else
            {
                mView.IsValid = false;
                List<string> brokenRules = model.GetBrokenRules(member);
                foreach (string item in brokenRules)
                {
                    mView.ShowMessage(item);
                }
            }
        }

        /// <summary>
        /// Initializes model values using view.
        /// </summary>
        /// <returns>Member model pupulated with View values.</returns>
        private MemberModel InitModel(IMemberView view)
        {
            return new MemberModel
            {
                FirstName = view.FirstName,
                LastName = view.LastName,
                Address = view.Address,
                City = view.City,
                State = view.State,
                Zip = view.Zip,
            };
        }
    }
}
