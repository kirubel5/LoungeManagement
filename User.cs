using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using NetsiLibrary;

namespace NetsiFlat
{
    public partial class User : Form
    {
        FormFormat format = new FormFormat();
        FileConnector connector = new FileConnector();
        Validation validation = new Validation();

        private string Id;
        private string FirstName;
        private string MiddleName;
        private string LastName;
        private string FullName;
        private string Balance;
        private string Date;
        private bool studentIsSelected;

        public User()
        {
            InitializeComponent();
            CreateNameList();
        }

        private void LoadInfo()
        {
            var user = connector.LoadUserInfo(Id);
            Date = user.RegistrationDate;
            FullName = user.UserName;

            var balance = connector.LoadBalanceInfo(Id);
            Balance = balance.Balance;
        }

        private void DisplayInfo()
        {
            if (studentIsSelected)
            {
                lblName.Visible = true;
                lblUserName.Visible = true;
                lblId.Visible = true;
                lblUserId.Visible = true;
                lblBalance.Visible = true;
                lblUserBalance.Visible = true;
                lblDate.Visible = true;
                lblUserDate.Visible = true;

                btnDeposit.Enabled = true;
                btnEdit.Enabled = true;
                btnHistory.Enabled = true;
                btnRemove.Enabled = true;

                LoadInfo();

                lblUserDate.Text = Date;
                lblUserName.Text = FullName;
                lblUserBalance.Text = Balance;
                lblUserId.Text = Id;
            }
        }

        private void HideInfo()
        {
            lblName.Visible = false;
            lblUserName.Visible = false;
            lblId.Visible = false;
            lblUserId.Visible = false;
            lblBalance.Visible = false;
            lblUserBalance.Visible = false;
            lblDate.Visible = false;
            lblUserDate.Visible = false;
            lblNotice.Visible = false;

            btnDeposit.Enabled = false;
            btnEdit.Enabled = false;
            btnHistory.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void OpenEditWindow()
        {
            btnEdit.Visible = false;
            btnRemove.Visible = false;
            btnDeposit.Visible = false;
            btnHistory.Visible = false;
            btnClear.Visible = false;

            lblName.Visible = false;
            lblUserName.Visible = false;
            lblId.Visible = false;
            lblUserId.Visible = false;
            lblBalance.Visible = false;
            lblUserBalance.Visible = false;
            lblDate.Visible = false;
            lblUserDate.Visible = false;

            btnSearch.Visible = false;
            txtUserSearch.Visible = false;
            pnlSearchShadow.Visible = false;
            dgvNameList.Visible = false;

            txtFirstName.Visible = true;
            txtMiddleName.Visible = true;
            txtLastName.Visible = true;
            pnlFirstNameShadow.Visible = false;
            pnlMiddleNameShadow.Visible = false;
            pnlLastNameShadow.Visible = false;
            btnSave.Visible = true;
            iconPictureBox1.Visible = true;
            btnBack.Visible = true;
        }

        private void CloseThisWindow()
        {
            btnEdit.Visible = true;
            btnRemove.Visible = true;
            btnDeposit.Visible = true;
            btnHistory.Visible = true;
            btnClear.Visible = true;
            btnTransactionBack.Visible = false;

            btnSearch.Visible = true;
            txtUserSearch.Visible = true;
            pnlSearchShadow.Visible = true;
            dgvNameList.Visible = true;

            txtFirstName.Visible = false;
            txtMiddleName.Visible = false;
            txtLastName.Visible = false;
            pnlFirstNameShadow.Visible = false;
            pnlMiddleNameShadow.Visible = false;
            pnlLastNameShadow.Visible = false;
            btnSave.Visible = false;
            iconPictureBox1.Visible = false;
            btnBack.Visible = false;
            btnUpdate.Visible = false;
            txtBalance.Visible = false;
            pnlBalanceShadow.Visible = false;
            dgvTransaction.Visible = false;

            format.ResetTextBox("  Enter First Name Here", txtFirstName, pnlFirstNameShadow);
            format.ResetTextBox("  Enter Middle Name Here", txtMiddleName, pnlMiddleNameShadow);
            format.ResetTextBox("  Enter Last Name Here", txtLastName, pnlLastNameShadow);
            format.ResetTextBox("  Enter Amount Here", txtBalance, pnlBalanceShadow);
        }

        private void OpenDepositWindow()
        {
            btnEdit.Visible = false;
            btnRemove.Visible = false;
            btnDeposit.Visible = false;
            btnHistory.Visible = false;
            btnClear.Visible = false;
            lblDate.Visible = false;
            lblUserDate.Visible = false;

            btnSearch.Visible = false;
            txtUserSearch.Visible = false;
            pnlSearchShadow.Visible = false;
            dgvNameList.Visible = false;

            txtBalance.Visible = true;
            pnlBalanceShadow.Visible = false;

            btnUpdate.Visible = true;
            iconPictureBox1.Visible = true;
            btnBack.Visible = true;
        }

        private void OpenTransactionWindow()
        {
            lblName.Visible = true;
            lblUserName.Visible = true;
            lblId.Visible = true;
            lblUserId.Visible = true;
            lblBalance.Visible = true;
            lblUserBalance.Visible = true;
            lblDate.Visible = true;
            lblUserDate.Visible = true;

            btnDeposit.Visible = false;
            btnEdit.Visible = false;
            btnHistory.Visible = false;
            btnRemove.Visible = false;
            btnBack.Visible = false;
            btnClear.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = false;
            txtUserSearch.Visible = false;
            pnlSearchShadow.Visible = false;
            btnSearch.Visible = false;
            dgvNameList.Visible = false;

            btnTransactionBack.Visible = true;
            dgvTransaction.Visible = true;

            LoadInfo();

            lblUserDate.Text = Date;
            lblUserName.Text = FullName;
            lblUserBalance.Text = Balance;
        }

        private bool AllCorrect()
        {
            bool allCorrect;

            FirstName = txtFirstName.Text;
            MiddleName = txtMiddleName.Text;
            LastName = txtLastName.Text;

            FirstName = FirstName.Trim();
            MiddleName = MiddleName.Trim();
            LastName = LastName.Trim();

            FirstName = FirstName.ToLower();
            MiddleName = MiddleName.ToLower();
            LastName = LastName.ToLower();

            FirstName = validation.CapitalizeFirstLetter(FirstName);
            MiddleName = validation.CapitalizeFirstLetter(MiddleName);
            LastName = validation.CapitalizeFirstLetter(LastName);

            if (validation.IsEmpty(FirstName, MiddleName, LastName))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* all values must be filled.";
                allCorrect = false;
            }
            else if (!validation.NoComma(FirstName, MiddleName, LastName))
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

        private bool BalanceCorrect()
        {
            bool balanceCorrect;

            Balance = txtBalance.Text;

            Balance = Balance.Trim();

            if (validation.IsEmpty(Balance))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* all values must be filled.";
                balanceCorrect = false;
            }
            else if (!validation.IsDouble(Balance))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* value has to be a number.";
                balanceCorrect = false;
            }
            else if (!validation.NoComma(Balance))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* please remove comma from value.";
                balanceCorrect = false;
            }
            else
            {
                lblNotice.Visible = false;
                balanceCorrect = true;
            }

            return balanceCorrect;
        }

        private void CreateNameList()
        {
            dgvNameList.DataSource = connector.CreatePersonDataTable();

            dgvNameList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNameList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNameList.Columns[0].Width = 100;

            dgvNameList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNameList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNameList.Columns[1].Width = 400;

            dgvNameList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNameList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvNameList.Columns[2].Width = 100;
        }

        private void LoadTransaction()
        {
            dgvTransaction.DataSource = connector.GetUserTransaction(Id);            

            dgvTransaction.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTransaction.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTransaction.Columns[0].Width = 130;

            dgvTransaction.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTransaction.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTransaction.Columns[1].Width = 400;

            dgvTransaction.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTransaction.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTransaction.Columns[2].Width = 80;
        }

        private bool ClearIsSure(string list)
        {
            string message = $"Are You Sure You Want to Clear { list }?";
            string title = "Clear";
            DialogResult a = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (a == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        private bool RemoveIsSure(string name)
        {
            string message = $"Are You Sure You Want to Remove { name }?";
            string title = "Remove";
            DialogResult a = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        #region Events

        private void User_Load(object sender, EventArgs e)
        {
            format.Search(txtUserSearch, connector.AutoCompeleteUserSearch());
        }

        private void btnDeposit_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightBtn((IconButton)sender, Color.FromArgb(24, 30, 54));
        }

        private void btnDeposit_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightBtn((IconButton)sender);
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightBtn((IconButton)sender, Color.Red);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightBtn((IconButton)sender);
        }

        private void txtUserSearch_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Search", (TextBox)sender, pnlSearchShadow);
        }

        private void txtUserSearch_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Search", (TextBox)sender, pnlSearchShadow);
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter First Name Here", (TextBox)sender, pnlFirstNameShadow, lblNotice);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter First Name Here", (TextBox)sender, pnlFirstNameShadow);
        }

        private void txtMiddleName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Middle Name Here", (TextBox)sender, pnlMiddleNameShadow, lblNotice);
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Middle Name Here", (TextBox)sender, pnlMiddleNameShadow);
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Last Name Here", (TextBox)sender, pnlLastNameShadow, lblNotice);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Last Name Here", (TextBox)sender, pnlLastNameShadow);
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Amount Here", (TextBox)sender, pnlBalanceShadow, lblNotice);
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Amount Here", (TextBox)sender, pnlBalanceShadow);
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightSaveBtn((IconButton)sender);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightSaveBtn((IconButton)sender);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenEditWindow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseThisWindow();
            HideInfo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ClearIsSure("User List"))
            {
                connector.ClearUser();
                CreateNameList();
                HideInfo();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveIsSure(FullName))
            {
                connector.RemoveUser(Id);
                CreateNameList();
                HideInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AllCorrect())
            {
                connector.EditUser(FirstName, MiddleName, LastName, Id);
                CreateNameList();
                HideInfo();
                CloseThisWindow();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            OpenDepositWindow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BalanceCorrect())
            {
                connector.UpdateBalance(Id, Balance);
                CreateNameList();
                HideInfo();
                CloseThisWindow();
            }
        }

        private void dgvNameList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNameList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvNameList.CurrentRow.Selected = true;
                studentIsSelected = true;
                Id = dgvNameList.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();

                DisplayInfo();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadTransaction();
            OpenTransactionWindow();
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            int index;

            try
            {
                index = format.Index(txtUserSearch.Text, dgvNameList);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            
            dgvNameList.Rows[index].Selected = true;
            dgvNameList.FirstDisplayedScrollingRowIndex = index;
        }

        #endregion
    }
}
