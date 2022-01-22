using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NetsiLibrary;

namespace NetsiFlat
{
    public partial class Netsi : Form
    {
        FormFormat format = new FormFormat();
        FileConnector connector = new FileConnector();
        Order order = new Order();
        Validation validation = new Validation();

        private IconButton currentBtn;
        private IconButton currentSubBtn;
        private Panel pnlNav;
        private Form currentChildForm;
        private DataTable foodList;

        private bool studentIsSelected;

        private string FullName;
        private string Id;
        private string Balance;

        private string FoodName;
        private string FoodPrice;
        private string Total;

        public Netsi()
        {
            InitializeComponent();

            pnlNav = new Panel
            {
                Size = new Size(7, 43)
            };

            pnlMain.Controls.Add(pnlNav);
        }

        private void Netsi_Load(object sender, EventArgs e)
        {
            pnlItem.Visible = false;
            pnlUser.Visible = false;

            ActivateBtn(btnOrder);
            OpenUserWindow();
            format.Search(txtItemSearch, connector.AutoCompeleteItemSearch());
            format.Search(txtUserSearch, connector.AutoCompeleteUserSearch());
        }

        private void LoadInfo()
        {
            var user = connector.LoadUserInfo(Id);
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

                LoadInfo();

                lblUserName.Text = FullName;
                lblUserId.Text = Id;
                lblUserBalance.Text = Balance;

                btnNext.Enabled = true;
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

            btnNext.Enabled = false;
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

        private void CreateFoodList()
        {
            dgvFoodListBeforeSelect.DataSource = connector.CreateFoodDataTable();

            if (dgvFoodListBeforeSelect.Rows.Count > 0)
            {
                dgvFoodListBeforeSelect.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvFoodListBeforeSelect.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvFoodListBeforeSelect.Columns[0].Width = 60;

                dgvFoodListBeforeSelect.Sort(dgvFoodListBeforeSelect.Columns[0], ListSortDirection.Ascending);

                dgvFoodListBeforeSelect.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvFoodListBeforeSelect.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void CreateSelectedFoodList()
        {
            foodList = new DataTable();

            foodList = order.CreateSelectedItemListDataTable(FoodName, FoodPrice);
            dgvFoodListAfterSelect.DataSource = foodList;

            dgvFoodListAfterSelect.AllowUserToOrderColumns = false;

            dgvFoodListAfterSelect.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvFoodListAfterSelect.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFoodListAfterSelect.Columns[0].Width = 50;

            dgvFoodListAfterSelect.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFoodListAfterSelect.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFoodListAfterSelect.Columns[1].Width = 100;

            dgvFoodListAfterSelect.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFoodListAfterSelect.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFoodListAfterSelect.Columns[2].Width = 60;

            dgvFoodListAfterSelect.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFoodListAfterSelect.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFoodListAfterSelect.Columns[3].Width = 80;

            dgvFoodListAfterSelect.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFoodListAfterSelect.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvFoodListAfterSelect.Columns[4].Width = 90;

            dgvFoodListAfterSelect.Columns[0].ReadOnly = true;
            dgvFoodListAfterSelect.Columns[1].ReadOnly = true;
            dgvFoodListAfterSelect.Columns[2].ReadOnly = true;
            dgvFoodListAfterSelect.Columns[3].ReadOnly = false;
            dgvFoodListAfterSelect.Columns[4].ReadOnly = true;

        }

        private void EmptySelectedFoodList()
        {
            order.ClearSelectedItemList();
            foodList = order.RefreshSelectedItemListDataTable();
            dgvFoodListAfterSelect.DataSource = foodList;
        }

        private void ActivateBtn(object senderBtn)
        {
            if (senderBtn != null)
            {
                DeactivateBtn();

                currentBtn = (IconButton)senderBtn;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ForeColor = Color.Tomato;
                currentBtn.IconColor = Color.Tomato;
                currentBtn.BackColor = Color.FromArgb(16, 20, 36);

                pnlNav.BackColor = Color.Tomato;
                pnlNav.Location = new Point(0, currentBtn.Location.Y);
                pnlNav.Visible = true;
                pnlNav.BringToFront();

                pbCurrentChildForm.IconChar = currentBtn.IconChar;
                pbCurrentChildForm.IconColor = currentBtn.ForeColor;
                lblCurrentChildForm.Text = currentBtn.Text;
                lblCurrentChildForm.ForeColor = currentBtn.ForeColor;
            }
        }

        private void DeactivateBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.BackColor = Color.FromArgb(24, 30, 54);
            }
        }

        private void ActivateSubMenu(object senderBtn)
        {
            if (senderBtn != null)
            {
                DeactivateSubMenu();

                currentSubBtn = (IconButton)senderBtn;
                currentSubBtn.BackColor = Color.FromArgb(46, 51, 73);
                currentSubBtn.ForeColor = Color.LightCoral;
                currentSubBtn.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DeactivateSubMenu()
        {
            if (currentSubBtn != null)
            {
                currentSubBtn.BackColor = Color.FromArgb(24, 30, 43);
                currentSubBtn.ForeColor = Color.Gainsboro;
                currentSubBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void HidePanels()
        {
            if (pnlUser.Visible == true)
                pnlUser.Visible = false;
            if (pnlItem.Visible == true)
                pnlItem.Visible = false;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            CloseUserWindow();
            CloseItemWindow();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            pnlDesktop.Controls.Add(panel1);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            DeactivateSubMenu();
            HidePanels();
            DeactivateBtn();
            pnlNav.Visible = false;
            pbCurrentChildForm.IconChar = IconChar.Home;
            pbCurrentChildForm.IconColor = Color.Gainsboro;
            lblCurrentChildForm.Text = "Home";
            lblCurrentChildForm.ForeColor = Color.Gainsboro;

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            CloseUserWindow();
            CloseItemWindow();
        }

        private void OpenUserWindow()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            CloseItemWindow();

            pnlThis.Visible = true;
            dgvNameList.Visible = true;
            btnNext.Visible = true;

            txtUserSearch.Visible = true;
            btnSearch.Visible = true;
            pnlSearchShadow.Visible = false;

            dgvNameList.BringToFront();

            pnlThis.Controls.Add(dgvNameList);
            pnlThis.Controls.Add(btnNext);
            pnlThis.Controls.Add(lblName);
            pnlThis.Controls.Add(lblBalance);
            pnlThis.Controls.Add(lblUserName);
            pnlThis.Controls.Add(lblUserBalance);
            pnlThis.Controls.Add(lblUserId);
            pnlThis.Controls.Add(txtUserSearch);
            pnlThis.Controls.Add(btnSearch);
            pnlThis.Controls.Add(pnlSearchShadow);

            CreateNameList();
        }

        private void CloseUserWindow()
        {
            pnlThis.Visible = false;
            dgvNameList.Visible = false;
            btnNext.Visible = false;
            lblName.Visible = false;
            lblBalance.Visible = false;
            lblId.Visible = false;
            lblUserName.Visible = false;
            lblUserBalance.Visible = false;
            lblUserId.Visible = false;

            txtUserSearch.Visible = false;
            btnSearch.Visible = false;
            pnlSearchShadow.Visible = false;

            txtUserSearch.Text = "  Search";
            txtUserSearch.ForeColor = Color.Gray;

            HideInfo();
        }

        private void OpenItemWindow()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            CloseUserWindow();
            CreateFoodList();

            pnlThis.Visible = true;
            lblETB.Visible = true;
            lblTotal.Visible = true;
            lblTotalAmount.Visible = true;
            lblTotalAmount.Text = "0";

            txtItemSearch.Visible = true;
            btnSearchItem.Visible = true;
            pnlSearchShadowItem.Visible = false;
            dgvFoodListBeforeSelect.Visible = true;
            dgvFoodListAfterSelect.Visible = true;

            lblNameItem.Visible = true;
            lblIdItem.Visible = true;
            lblBalanceItem.Visible = true;
            lblUserNameItem.Visible = true;
            lblUserIdItem.Visible = true;
            lblUserBalanceItem.Visible = true;
            lblSelectedFood.Visible = true;

            btnBack.Visible = true;
            btnFinish.Visible = true;

            lblUserNameItem.Text = FullName;
            lblUserIdItem.Text = Id;
            lblUserBalanceItem.Text = Balance;

            pnlThis.Controls.Add(lblNameItem);
            pnlThis.Controls.Add(lblIdItem);
            pnlThis.Controls.Add(lblBalanceItem);
            pnlThis.Controls.Add(lblUserNameItem);
            pnlThis.Controls.Add(lblUserIdItem);
            pnlThis.Controls.Add(lblUserBalanceItem);
            pnlThis.Controls.Add(lblSelectedFood);
            pnlThis.Controls.Add(lblETB);
            pnlThis.Controls.Add(lblTotal);
            pnlThis.Controls.Add(lblTotalAmount);

            pnlThis.Controls.Add(txtItemSearch);
            pnlThis.Controls.Add(btnSearchItem);
            pnlThis.Controls.Add(pnlSearchShadowItem);
            pnlThis.Controls.Add(dgvFoodListBeforeSelect);
            pnlThis.Controls.Add(dgvFoodListAfterSelect);
            pnlThis.Controls.Add(btnBack);
            pnlThis.Controls.Add(btnFinish);
        }

        private void CloseItemWindow()
        {
            pnlThis.Visible = false;
            lblNameItem.Visible = false;
            lblIdItem.Visible = false;
            lblBalanceItem.Visible = false;
            lblUserNameItem.Visible = false;
            lblUserIdItem.Visible = false;
            lblUserBalanceItem.Visible = false;
            lblSelectedFood.Visible = false;

            lblETB.Visible = false;
            lblTotal.Visible = false;
            lblTotalAmount.Visible = false;

            txtItemSearch.Visible = false;
            btnSearchItem.Visible = false;
            pnlSearchShadowItem.Visible = false;
            dgvFoodListBeforeSelect.Visible = false;
            dgvFoodListAfterSelect.Visible = false;

            btnBack.Visible = false;
            btnFinish.Visible = false;

            txtItemSearch.Text = "  Search";
            txtItemSearch.ForeColor = Color.Gray;

            EmptySelectedFoodList();
        }

        private bool ContinueWithDebt()
        {
            string title = "Continue with debt";
            string message = "Balance of the user is insufficient.\nContinue with debt?";

            DialogResult a = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (a == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool DataGridIsEmpty(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                string title = "Empty";
                string message = "There is no item selected.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Events 

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DeactivateSubMenu();
            HidePanels();
            ActivateBtn(sender);

            OpenUserWindow();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            DeactivateSubMenu();
            HidePanels();
            ActivateBtn(sender);
            pnlUser.Visible = true;

            OpenChildForm(new User());
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            DeactivateSubMenu();
            HidePanels();
            ActivateBtn(sender);
            pnlItem.Visible = true;

            OpenChildForm(new Item());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            DeactivateSubMenu();
            HidePanels();
            ActivateBtn(sender);
        }

        private void pnlLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ActivateSubMenu(sender);
            OpenChildForm(new AddUser());
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ActivateSubMenu(sender);
            OpenChildForm(new AddItem());
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightSaveBtn((IconButton)sender);
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightSaveBtn((IconButton)sender);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenUserWindow();
            HideInfo();
        }

        private void txtUserSearch_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Search", (TextBox)sender, pnlSearchShadow);
        }

        private void txtUserSearch_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Search", (TextBox)sender, pnlSearchShadow);
        }

        private void txtItemSearch_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Search", (TextBox)sender, pnlSearchShadowItem);
        }

        private void txtItemSearch_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Search", (TextBox)sender, pnlSearchShadowItem);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            OpenItemWindow();
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

        private void dgvFoodListBeforeSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFoodListBeforeSelect.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvFoodListBeforeSelect.CurrentRow.Selected = true;

                FoodName = dgvFoodListBeforeSelect.Rows[e.RowIndex].Cells["Food Name"].FormattedValue.ToString();
                FoodPrice = dgvFoodListBeforeSelect.Rows[e.RowIndex].Cells["Food Price"].FormattedValue.ToString();

                CreateSelectedFoodList();

                lblTotalAmount.Text = order.CalculateTotal(dgvFoodListAfterSelect);
            }
        }

        private void dgvFoodListAfterSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFoodListAfterSelect.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string selectedFoodName = dgvFoodListAfterSelect.Rows[e.RowIndex].Cells["Food Name"].FormattedValue.ToString();

                order.RemoveSelectedItemList(selectedFoodName);
                foodList = order.RefreshSelectedItemListDataTable();
                dgvFoodListAfterSelect.DataSource = foodList;

                lblTotalAmount.Text = order.CalculateTotal(dgvFoodListAfterSelect);
            }
        }

        private void dgvFoodListAfterSelect_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string price = dgvFoodListAfterSelect.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            double doublePrice = double.Parse(price);
            string quantity = dgvFoodListAfterSelect.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            int intQuantity;

            if (validation.IsInteger(quantity))
            {
                intQuantity = int.Parse(quantity);
            }
            else
            {
                intQuantity = 1;
                dgvFoodListAfterSelect.Rows[e.RowIndex].Cells["Quantity"].Value = "1";
            }

            string selectedFoodName = dgvFoodListAfterSelect.Rows[e.RowIndex].Cells["Food Name"].FormattedValue.ToString();
            order.UpdateQuantity(selectedFoodName, intQuantity);

            double doubleSubTotal = doublePrice * intQuantity;
            string subTotal = doubleSubTotal.ToString();

            dgvFoodListAfterSelect.Rows[e.RowIndex].Cells[4].Value = subTotal;
            lblTotalAmount.Text = order.CalculateTotal(dgvFoodListAfterSelect);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            lblTotalAmount.Text = order.CalculateTotal(dgvFoodListAfterSelect);
            Total = order.CalculateTotal(dgvFoodListAfterSelect);

            string totalNegative = "-" + Total;
            double doubleTotal = double.Parse(Total);
            double doubleBalance = double.Parse(Balance);

            if (DataGridIsEmpty(dgvFoodListAfterSelect))
            {
                return;
            }
            else if (doubleTotal > doubleBalance)
            {
                if (ContinueWithDebt())
                {
                    connector.UpdateBalance(Id, totalNegative);
                    order.GenerateTransaction(Id, Total, dgvFoodListAfterSelect);
                    OpenUserWindow();
                }
            }
            else
            {
                connector.UpdateBalance(Id, totalNegative);
                order.GenerateTransaction(Id, Total, dgvFoodListAfterSelect);
                OpenUserWindow();
            }
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

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            int index;

            try
            {
                index = format.Index(txtItemSearch.Text, dgvFoodListBeforeSelect);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            
            dgvFoodListBeforeSelect.Rows[index].Selected = true;
            dgvFoodListBeforeSelect.FirstDisplayedScrollingRowIndex = index;
        }

        #endregion
    }
}
