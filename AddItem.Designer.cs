namespace NetsiFlat
{
    partial class AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.pnlFoodNameShadow = new System.Windows.Forms.Panel();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.pnlFoodPriceShadow = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.AliceBlue;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Location = new System.Drawing.Point(260, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 53);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "      Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 148;
            this.iconPictureBox1.Location = new System.Drawing.Point(260, 32);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(240, 148);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.ForeColor = System.Drawing.Color.Gray;
            this.txtFoodName.Location = new System.Drawing.Point(260, 186);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(293, 25);
            this.txtFoodName.TabIndex = 17;
            this.txtFoodName.Text = "  Enter Food Name Here";
            this.txtFoodName.Enter += new System.EventHandler(this.txtFoodName_Enter);
            this.txtFoodName.Leave += new System.EventHandler(this.txtFoodName_Leave);
            // 
            // pnlFoodNameShadow
            // 
            this.pnlFoodNameShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFoodNameShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlFoodNameShadow.Location = new System.Drawing.Point(260, 213);
            this.pnlFoodNameShadow.Name = "pnlFoodNameShadow";
            this.pnlFoodNameShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlFoodNameShadow.TabIndex = 18;
            this.pnlFoodNameShadow.Visible = false;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtFoodPrice.Location = new System.Drawing.Point(260, 242);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(293, 25);
            this.txtFoodPrice.TabIndex = 17;
            this.txtFoodPrice.Text = "  Enter Food Price Here";
            this.txtFoodPrice.Enter += new System.EventHandler(this.txtFoodPrice_Enter);
            this.txtFoodPrice.Leave += new System.EventHandler(this.txtFoodPrice_Leave);
            // 
            // pnlFoodPriceShadow
            // 
            this.pnlFoodPriceShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFoodPriceShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlFoodPriceShadow.Location = new System.Drawing.Point(260, 269);
            this.pnlFoodPriceShadow.Name = "pnlFoodPriceShadow";
            this.pnlFoodPriceShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlFoodPriceShadow.TabIndex = 18;
            this.pnlFoodPriceShadow.Visible = false;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Tomato;
            this.lblNotice.Location = new System.Drawing.Point(257, 286);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(243, 14);
            this.lblNotice.TabIndex = 19;
            this.lblNotice.Text = "*all fields must be filled.";
            this.lblNotice.Visible = false;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.pnlFoodPriceShadow);
            this.Controls.Add(this.pnlFoodNameShadow);
            this.Controls.Add(this.txtFoodPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.Text = "AddItem";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Panel pnlFoodNameShadow;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.Panel pnlFoodPriceShadow;
        private System.Windows.Forms.Label lblNotice;
    }
}