using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using NetsiLibrary;

namespace NetsiFlat
{
    public partial class AddItem : Form
    {
        FormFormat format = new FormFormat();
        Validation validation = new Validation();
        FileConnector fileConnector = new FileConnector();

        public string FoodName;
        public string FoodPrice;

        public AddItem()
        {
            InitializeComponent();
        }

        private void ResetTextBox()
        {
            txtFoodName.Text = "  Enter Food Name Here";
            txtFoodPrice.Text = "  Enter Food Price Here";
            txtFoodName.ForeColor = Color.Gray;
            txtFoodPrice.ForeColor = Color.Gray;
            pnlFoodNameShadow.Visible = false;
            pnlFoodPriceShadow.Visible = false;
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
                lblNotice.Text = "* Food Price has to be a number value.";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AllCorrect())
            {
                FoodName = FoodName.ToLower();

                if (fileConnector.ItemExists(FoodName))
                {
                    lblNotice.Text = "* file already exists";
                    lblNotice.Visible = true;
                }
                else
                {
                    fileConnector.CreateItem(FoodName, FoodPrice);
                    ResetTextBox();
                }
            }
        }

        #region Events

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            format.HighlightSaveBtn((IconButton)sender);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            format.DeHighlightSaveBtn((IconButton)sender);
        }

        private void txtFoodName_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Food Name Here", (TextBox)sender, pnlFoodNameShadow, lblNotice);
        }

        private void txtFoodName_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Food Name Here", (TextBox)sender, pnlFoodNameShadow);
        }

        private void txtFoodPrice_Enter(object sender, EventArgs e)
        {
            format.EnterTextBox("  Enter Food Price Here", (TextBox)sender, pnlFoodPriceShadow, lblNotice);
        }

        private void txtFoodPrice_Leave(object sender, EventArgs e)
        {
            format.LeaveTextBox("  Enter Food Price Here", (TextBox)sender, pnlFoodPriceShadow);
        }

        #endregion       
    }
}
