using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NetsiLibrary;

namespace NetsiFlat
{
    public partial class Item : Form
    {
        FormFormat format = new FormFormat();
        FileConnector connector = new FileConnector();
        Validation validation = new Validation();

        private bool studentIsSelected;
        private string FoodName;
        private string FoodPrice;
        private string OldFoodName;

        public Item()
        {
            InitializeComponent();
        }

        private void DisplayInfo()
        {
            if (studentIsSelected)
            {
                lblEtb.Visible = true;
                lblName.Visible = true;
                lblFoodName.Visible = true;
                lblPrice.Visible = true;
                lblFoodPrice.Visible = true;

                btnEdit.Enabled = true;
                btnRemove.Enabled = true;

                lblFoodName.Text = OldFoodName;
                lblFoodPrice.Text = FoodPrice;
            }
        }

        private void HideInfo()
        {
            lblEtb.Visible = false;
            lblName.Visible = false;
            lblFoodName.Visible = false;
            lblPrice.Visible = false;
            lblFoodPrice.Visible = false;

            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void OpenEditWindow()
        {
            txtItemSearch.Visible = false;
            btnSearch.Visible = false;
            pnlSearchShadow.Visible = false;

            HideInfo();

            btnEdit.Visible = false;
            btnRemove.Visible = false;
            btnClear.Visible = false;
            dgvFoodList.Visible = false;

            btnBack.Visible = true;
            iconPictureBox1.Visible = true;
            txtFoodName.Visible = true;
            txtFoodPrice.Visible = true;
            pnlFoodNameShadow.Visible = true;
            pnlFoodPriceShadow.Visible = true;
            btnSave.Visible = true;

            txtFoodName.Text = OldFoodName;
            txtFoodPrice.Text = FoodPrice;
        }

        private void CloseEditWindow()
        {
            txtItemSearch.Visible = true;
            btnSearch.Visible = true;
            pnlSearchShadow.Visible = true;

            HideInfo();

            btnEdit.Visible = true;
            btnRemove.Visible = true;
            btnClear.Visible = true;
            dgvFoodList.Visible = true;

            btnBack.Visible = false;
            iconPictureBox1.Visible = false;
            txtFoodName.Visible = false;
            txtFoodPrice.Visible = false;
            pnlFoodNameShadow.Visible = false;
            pnlFoodPriceShadow.Visible = false;
            btnSave.Visible = false;
            lblNotice.Visible = false;
        }

        private bool AllCorrect()
        {
            bool allCorrect;

            FoodName = txtFoodName.Text;
            FoodPrice = txtFoodPrice.Text;

            FoodName = FoodName.Trim();
            FoodPrice = FoodPrice.Trim();

            if (validation.IsEmpty(FoodName, FoodPrice))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* all values must be filled.";
                allCorrect = false;
            }
            else if (!validation.IsDouble(FoodPrice))
            {
                lblNotice.Visible = true;
                lblNotice.Text = "* Food Price has to be a number.";
                allCorrect = false;
            }
            else if (!validation.NoComma(FoodName, FoodPrice))
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

        private void CreateFoodList()
        {
            dgvFoodList.DataSource = connector.CreateFoodDataTable();

            if (dgvFoodList.Rows.Count > 0)
            {
                dgvFoodList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvFoodList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvFoodList.Columns[0].Width = 60;

                dgvFoodList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvFoodList.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvFoodList.Sort(dgvFoodList.Columns[0], ListSortDirection.Ascending);
            }
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

        private void Item_Load(object sender, EventArgs e)
        {
            CreateFoodList();
            format.Search(txtItemSearch, connector.AutoCompeleteItemSearch());
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightBtn((IconButton)sender, Color.Red);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightBtn((IconButton)sender);
        }

        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightBtn((IconButton)sender, Color.FromArgb(24, 30, 54));
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightBtn((IconButton)sender);
        }

        private void txtItemSearch_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Search", (TextBox)sender, pnlSearchShadow);
        }

        private void txtItemSearch_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Search", (TextBox)sender, pnlSearchShadow);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ClearIsSure("Item List"))
            {
                connector.ClearItem();
                CreateFoodList();
                HideInfo();
            }
        }

        private void dgvFoodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvFoodList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvFoodList.CurrentRow.Selected = true;
                studentIsSelected = true;

                OldFoodName = dgvFoodList.Rows[e.RowIndex].Cells["Food Name"].FormattedValue.ToString();
                FoodPrice = dgvFoodList.Rows[e.RowIndex].Cells["Food Price"].FormattedValue.ToString();

                DisplayInfo();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenEditWindow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseEditWindow();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightSaveBtn((IconButton)sender);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightSaveBtn((IconButton)sender);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveIsSure(OldFoodName))
            {
                connector.RemoveItem(OldFoodName);
                CreateFoodList();
                HideInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (AllCorrect())
            {
                FoodName = FoodName.ToLower();

                connector.EditItem(OldFoodName, FoodName, FoodPrice);
                CreateFoodList();
                CloseEditWindow();
                HideInfo();
            }
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            int index;

            try
            {
                index = format.Index(txtItemSearch.Text, dgvFoodList);
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
            
            dgvFoodList.Rows[index].Selected = true;
            dgvFoodList.FirstDisplayedScrollingRowIndex = index;
        }

        #endregion
    }
}
