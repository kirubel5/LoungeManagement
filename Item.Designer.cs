namespace NetsiFlat
{
    partial class Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.pnlSearchShadow = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblEtb = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pnlFoodPriceShadow = new System.Windows.Forms.Panel();
            this.pnlFoodNameShadow = new System.Windows.Forms.Panel();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtItemSearch.Location = new System.Drawing.Point(566, 12);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(210, 19);
            this.txtItemSearch.TabIndex = 0;
            this.txtItemSearch.Text = "  Search";
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            this.txtItemSearch.Enter += new System.EventHandler(this.txtItemSearch_Enter);
            this.txtItemSearch.Leave += new System.EventHandler(this.txtItemSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 23;
            this.btnSearch.Location = new System.Drawing.Point(771, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEdit.Location = new System.Drawing.Point(696, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 25;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRemove.Location = new System.Drawing.Point(580, 426);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 25;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClear.Location = new System.Drawing.Point(464, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 34);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // pnlSearchShadow
            // 
            this.pnlSearchShadow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlSearchShadow.Location = new System.Drawing.Point(563, 36);
            this.pnlSearchShadow.Name = "pnlSearchShadow";
            this.pnlSearchShadow.Size = new System.Drawing.Size(243, 1);
            this.pnlSearchShadow.TabIndex = 25;
            this.pnlSearchShadow.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(562, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name :";
            this.lblName.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.Location = new System.Drawing.Point(562, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 23);
            this.lblPrice.TabIndex = 26;
            this.lblPrice.Text = "Price  :";
            this.lblPrice.Visible = false;
            // 
            // lblFoodName
            // 
            this.lblFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodName.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFoodName.Location = new System.Drawing.Point(635, 108);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(171, 23);
            this.lblFoodName.TabIndex = 26;
            this.lblFoodName.Text = "Food Name";
            this.lblFoodName.Visible = false;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFoodPrice.Location = new System.Drawing.Point(636, 144);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(54, 23);
            this.lblFoodPrice.TabIndex = 26;
            this.lblFoodPrice.Text = "Food Price";
            this.lblFoodPrice.Visible = false;
            // 
            // lblEtb
            // 
            this.lblEtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEtb.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtb.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEtb.Location = new System.Drawing.Point(696, 144);
            this.lblEtb.Name = "lblEtb";
            this.lblEtb.Size = new System.Drawing.Size(54, 23);
            this.lblEtb.TabIndex = 26;
            this.lblEtb.Text = "ETB";
            this.lblEtb.Visible = false;
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.AllowUserToDeleteRows = false;
            this.dgvFoodList.AllowUserToResizeColumns = false;
            this.dgvFoodList.AllowUserToResizeRows = false;
            this.dgvFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.dgvFoodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoodList.ColumnHeadersHeight = 41;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoodList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFoodList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvFoodList.Location = new System.Drawing.Point(0, 0);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.NullValue = "Not Set";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoodList.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.NullValue = "Not Set";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoodList.RowTemplate.Height = 25;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(496, 356);
            this.dgvFoodList.TabIndex = 28;
            this.dgvFoodList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellClick);
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Tomato;
            this.lblNotice.Location = new System.Drawing.Point(286, 320);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(243, 14);
            this.lblNotice.TabIndex = 35;
            this.lblNotice.Text = "*all fields must be filled.";
            this.lblNotice.Visible = false;
            // 
            // pnlFoodPriceShadow
            // 
            this.pnlFoodPriceShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFoodPriceShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlFoodPriceShadow.Location = new System.Drawing.Point(289, 303);
            this.pnlFoodPriceShadow.Name = "pnlFoodPriceShadow";
            this.pnlFoodPriceShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlFoodPriceShadow.TabIndex = 33;
            this.pnlFoodPriceShadow.Visible = false;
            // 
            // pnlFoodNameShadow
            // 
            this.pnlFoodNameShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFoodNameShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlFoodNameShadow.Location = new System.Drawing.Point(289, 247);
            this.pnlFoodNameShadow.Name = "pnlFoodNameShadow";
            this.pnlFoodNameShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlFoodNameShadow.TabIndex = 34;
            this.pnlFoodNameShadow.Visible = false;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodPrice.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFoodPrice.Location = new System.Drawing.Point(289, 276);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(244, 25);
            this.txtFoodPrice.TabIndex = 31;
            this.txtFoodPrice.Text = "  Enter Food Price Here";
            this.txtFoodPrice.Visible = false;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFoodName.Location = new System.Drawing.Point(289, 220);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(244, 25);
            this.txtFoodName.TabIndex = 32;
            this.txtFoodName.Text = "  Enter Food Name Here";
            this.txtFoodName.Visible = false;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(289, 66);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(240, 148);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 30;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Visible = false;
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
            this.btnSave.Location = new System.Drawing.Point(289, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 53);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "      Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 25;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBack.Location = new System.Drawing.Point(580, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 34);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            // 
            // Item
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
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEtb);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlSearchShadow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtItemSearch);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.Panel pnlSearchShadow;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblFoodName;
        public System.Windows.Forms.Label lblFoodPrice;
        public System.Windows.Forms.Label lblEtb;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Panel pnlFoodPriceShadow;
        private System.Windows.Forms.Panel pnlFoodNameShadow;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}