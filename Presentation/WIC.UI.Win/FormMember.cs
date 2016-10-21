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

            // initialize presenter.
            memberPresenter = new MemberPresenter(this);
        }

        public int MemberId { get; set; }

        public string MemberName
        {
            get { return txtMemberName.Text.Trim(); }
            set { txtMemberName.Text = value; }
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
                    //memberPresenter.Save();
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

        //private void btnSave_Click(object sender, EventArgs e)
        //{            
        //    // Validate View using model
        //    memberPresenter.isValidMember();

        //    if (IsValid)
        //    {
        //        memberPresenter.Save();

        //        // For now, one save only.
        //        btnSave.Enabled = false;
        //        lblMessage.Text = "Saved successfully!";
        //        lblMessage.ForeColor = Color.Green;
        //    }
        //}

        //private void mView_Save(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Validate View using model
        //        memberPresenter.isValidMember();

        //        if (IsValid)
        //        {
        //            memberPresenter.Save();

        //            // For now, one save only.
        //            btnSave.Enabled = false;
        //            lblMessage.Text = "Saved successfully!";
        //            lblMessage.ForeColor = Color.Green;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowMessage(ex.Message);
        //    }
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void InitializeApply()
        {
            cboState.DataSource = MemberController.GetStates();
        }
    }
}
