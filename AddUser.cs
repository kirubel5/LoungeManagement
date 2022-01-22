using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using NetsiLibrary;

namespace NetsiFlat
{
    public partial class AddUser : Form
    {
        FormFormat format = new FormFormat();
        Validation validation = new Validation();
        FileConnector fileConnector = new FileConnector();

        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string InitialDeposit;
        public string Date;

        public AddUser()
        {
            InitializeComponent();
        }

        private void ResetTextBox()
        {
            txtFirstName.Text = "  Enter First Name Here";
            txtMiddleName.Text = "  Enter Middle Name Here";
            txtLastName.Text = "  Enter Last Name Here";
            txtInitialDeposit.Text = "  Enter Initial Deposit Here";

            txtFirstName.ForeColor = Color.Gray;
            txtMiddleName.ForeColor = Color.Gray;
            txtLastName.ForeColor = Color.Gray;
            txtInitialDeposit.ForeColor = Color.Gray;

            pnlFirstNameShadow.Visible = false;
            pnlMiddleNameShadow.Visible = false;
            pnlLastNameShadow.Visible = false;
            pnlInitialDepositShadow.Visible = false;
        }

        private bool AllCorrect()
        {
            bool allCorrect;

            FirstName = txtFirstName.Text;
            MiddleName = txtMiddleName.Text;
            LastName = txtLastName.Text;
            InitialDeposit = txtInitialDeposit.Text;

            FirstName = FirstName.Trim();
            MiddleName = MiddleName.Trim();
            LastName = LastName.Trim();
            InitialDeposit = InitialDeposit.Trim();

            FirstName = FirstName.ToLower();
            MiddleName = MiddleName.ToLower();
            LastName = LastName.ToLower();

            FirstName = validation.CapitalizeFirstLetter(FirstName);
            MiddleName = validation.CapitalizeFirstLetter(MiddleName);
            LastName = validation.CapitalizeFirstLetter(LastName);

            if (validation.IsEmpty(FirstName, MiddleName, LastName, InitialDeposit))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* all values must be filled.";
                allCorrect = false;
            }
            else if (!validation.IsDouble(InitialDeposit))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* Initial Deposit Has to be a number value.";
                allCorrect = false;
            }
            else if (!validation.NoComma(FirstName, MiddleName, LastName, InitialDeposit))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* please remove comma(s) from values.";
                allCorrect = false;
            }
            else
            {
                lblNotice.Visible = false;
                allCorrect = true;
            }

            return allCorrect;
        }

        #region Events           

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter First Name Here", (TextBox)sender, pnlFirstNameShadow, lblNotice);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter First Name Here", (TextBox)sender, pnlFirstNameShadow);
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Middle Name Here", (TextBox)sender, pnlMiddleNameShadow);
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Middle Name Here", (TextBox)sender, pnlMiddleNameShadow, lblNotice);
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Last Name Here", (TextBox)sender, pnlLastNameShadow, lblNotice);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Last Name Here", (TextBox)sender, pnlLastNameShadow);
        }

        private void txtInitialDeposit_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Initial Deposit Here", (TextBox)sender, pnlInitialDepositShadow, lblNotice);
        }

        private void txtInitialDeposit_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Initial Deposit Here", (TextBox)sender, pnlInitialDepositShadow);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightSaveBtn((IconButton)sender);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightSaveBtn((IconButton)sender);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (AllCorrect())
            {
                fileConnector.CreateUser(FirstName, MiddleName, LastName, InitialDeposit);
                ResetTextBox();
            }
        }

        #endregion
    }
}
