using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIC.UI.Win.Presenters;
using WIC.UI.Win.Views;
using WIC.UI.Process;

namespace WIC.UI.Win
{
    public partial class FormMember : Form, IMemberView
    {
        private MemberPresenter memberPresenter;

        public event EventHandler<EventArgs> Save;

        public FormMember()
        {
            InitializeComponent();
            InitializeApply();

            // Initialize Member presenter.
            memberPresenter = new MemberPresenter(this);
        }

        public int MemberId { get; set; }

        public string FirstName
        {
            get { return txtFirstName.Text.Trim(); }
            set { txtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return txtLastName.Text.Trim(); }
            set { txtLastName.Text = value; }
        }

        public string Address
        {
            get { return txtAddress.Text.Trim(); }
            set { txtAddress.Text = value; }
        }

        public string City
        {
            get { return txtCity.Text.Trim(); }
            set { txtCity.Text = value; }
        }

        public string State
        {
            get { return cboState.SelectedValue.ToString(); }
            set { cboState.SelectedValue = value; }
        }

        public string Zip
        {
            get { return txtZIP.Text.Trim(); }
            set { txtZIP.Text = value; }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public bool IsValid { get; set; }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate View using model
                memberPresenter.isValidMember();

                if (IsValid)
                {
                    // IDE1005: Simplified delegation invoke of presenter method.
                    Save?.Invoke(this, EventArgs.Empty);

                    // For now, one save only.
                    btnSave.Enabled = false;
                    lblMessage.Text = "Saved successfully!";
                    lblMessage.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Todo: Create cancel event, handler & delegate.  
            this.Close();
        }

        private void InitializeApply()
        {
            // Todo: Better incorporate list lookup into View and Presenter.  Consider StateCollection : List<State>.
            cboState.DataSource = MemberController.GetStates();
        }
    }
}
