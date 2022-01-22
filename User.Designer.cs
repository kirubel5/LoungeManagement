namespace NetsiFlat
{
    partial class User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.btnHistory = new FontAwesome.Sharp.IconButton();
            this.btnDeposit = new FontAwesome.Sharp.IconButton();
            this.pnlSearchShadow = new System.Windows.Forms.Panel();
            this.dgvNameList = new System.Windows.Forms.DataGridView();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUserBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblUserDate = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pnlLastNameShadow = new System.Windows.Forms.Panel();
            this.pnlMiddleNameShadow = new System.Windows.Forms.Panel();
            this.pnlFirstNameShadow = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.pnlBalanceShadow = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.btnTransactionBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.UsersSlash;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 25;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClear.Location = new System.Drawing.Point(234, 426);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnClear.Size = new System.Drawing.Size(110, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 25;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRemove.Location = new System.Drawing.Point(350, 426);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 34);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btnDeposit_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
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
            this.btnEdit.Location = new System.Drawing.Point(465, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnDeposit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
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
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserSearch.Location = new System.Drawing.Point(564, 12);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(211, 19);
            this.txtUserSearch.TabIndex = 3;
            this.txtUserSearch.Text = "  Search";
            this.txtUserSearch.TextChanged += new System.EventHandler(this.txtUserSearch_TextChanged);
            this.txtUserSearch.Enter += new System.EventHandler(this.txtUserSearch_Enter);
            this.txtUserSearch.Leave += new System.EventHandler(this.txtUserSearch_Leave);
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnHistory.Enabled = false;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistory.IconColor = System.Drawing.Color.Black;
            this.btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistory.IconSize = 25;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHistory.Location = new System.Drawing.Point(695, 426);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(110, 34);
            this.btnHistory.TabIndex = 8;
            this.btnHistory.Text = "History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.btnDeposit_MouseEnter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnDeposit.Enabled = false;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            this.btnDeposit.IconColor = System.Drawing.Color.Black;
            this.btnDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeposit.IconSize = 25;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDeposit.Location = new System.Drawing.Point(580, 426);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(110, 34);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnDeposit.MouseEnter += new System.EventHandler(this.btnDeposit_MouseEnter);
            this.btnDeposit.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
            // 
            // pnlSearchShadow
            // 
            this.pnlSearchShadow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlSearchShadow.Location = new System.Drawing.Point(564, 36);
            this.pnlSearchShadow.Name = "pnlSearchShadow";
            this.pnlSearchShadow.Size = new System.Drawing.Size(243, 1);
            this.pnlSearchShadow.TabIndex = 26;
            this.pnlSearchShadow.Visible = false;
            // 
            // dgvNameList
            // 
            this.dgvNameList.AllowUserToAddRows = false;
            this.dgvNameList.AllowUserToDeleteRows = false;
            this.dgvNameList.AllowUserToOrderColumns = true;
            this.dgvNameList.AllowUserToResizeColumns = false;
            this.dgvNameList.AllowUserToResizeRows = false;
            this.dgvNameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNameList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.dgvNameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNameList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNameList.ColumnHeadersHeight = 41;
            this.dgvNameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNameList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNameList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.dgvNameList.Location = new System.Drawing.Point(0, 0);
            this.dgvNameList.MultiSelect = false;
            this.dgvNameList.Name = "dgvNameList";
            this.dgvNameList.ReadOnly = true;
            this.dgvNameList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.NullValue = "Not Set";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNameList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNameList.RowHeadersVisible = false;
            this.dgvNameList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "Not Set";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNameList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNameList.RowTemplate.Height = 25;
            this.dgvNameList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNameList.Size = new System.Drawing.Size(448, 396);
            this.dgvNameList.TabIndex = 27;
            this.dgvNameList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNameList_CellClick);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserName.Location = new System.Drawing.Point(533, 94);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(274, 23);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "User Name";
            this.lblUserName.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(466, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 23);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name :";
            this.lblName.Visible = false;
            // 
            // lblUserId
            // 
            this.lblUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserId.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserId.Location = new System.Drawing.Point(533, 129);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(141, 23);
            this.lblUserId.TabIndex = 30;
            this.lblUserId.Text = "User ID";
            this.lblUserId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblId.Location = new System.Drawing.Point(466, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 23);
            this.lblId.TabIndex = 31;
            this.lblId.Text = "ID : ";
            this.lblId.Visible = false;
            // 
            // lblUserBalance
            // 
            this.lblUserBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserBalance.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserBalance.Location = new System.Drawing.Point(549, 164);
            this.lblUserBalance.Name = "lblUserBalance";
            this.lblUserBalance.Size = new System.Drawing.Size(182, 23);
            this.lblUserBalance.TabIndex = 32;
            this.lblUserBalance.Text = "User Balance";
            this.lblUserBalance.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBalance.Location = new System.Drawing.Point(466, 164);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(87, 23);
            this.lblBalance.TabIndex = 33;
            this.lblBalance.Text = "Balance : ";
            this.lblBalance.Visible = false;
            // 
            // lblUserDate
            // 
            this.lblUserDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserDate.Location = new System.Drawing.Point(590, 199);
            this.lblUserDate.Name = "lblUserDate";
            this.lblUserDate.Size = new System.Drawing.Size(185, 23);
            this.lblUserDate.TabIndex = 34;
            this.lblUserDate.Text = "User Date";
            this.lblUserDate.Visible = false;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.Tomato;
            this.lblNotice.Location = new System.Drawing.Point(274, 282);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(269, 14);
            this.lblNotice.TabIndex = 45;
            this.lblNotice.Text = "*all fields must be filled";
            this.lblNotice.Visible = false;
            // 
            // pnlLastNameShadow
            // 
            this.pnlLastNameShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLastNameShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlLastNameShadow.Location = new System.Drawing.Point(277, 265);
            this.pnlLastNameShadow.Name = "pnlLastNameShadow";
            this.pnlLastNameShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlLastNameShadow.TabIndex = 42;
            this.pnlLastNameShadow.Visible = false;
            // 
            // pnlMiddleNameShadow
            // 
            this.pnlMiddleNameShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMiddleNameShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlMiddleNameShadow.Location = new System.Drawing.Point(277, 218);
            this.pnlMiddleNameShadow.Name = "pnlMiddleNameShadow";
            this.pnlMiddleNameShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlMiddleNameShadow.TabIndex = 43;
            this.pnlMiddleNameShadow.Visible = false;
            // 
            // pnlFirstNameShadow
            // 
            this.pnlFirstNameShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFirstNameShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlFirstNameShadow.Location = new System.Drawing.Point(277, 176);
            this.pnlFirstNameShadow.Name = "pnlFirstNameShadow";
            this.pnlFirstNameShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlFirstNameShadow.TabIndex = 44;
            this.pnlFirstNameShadow.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.Location = new System.Drawing.Point(277, 238);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 25);
            this.txtLastName.TabIndex = 38;
            this.txtLastName.Text = "  Enter Last Name Here";
            this.txtLastName.Visible = false;
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.Gray;
            this.txtMiddleName.Location = new System.Drawing.Point(277, 191);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(240, 25);
            this.txtMiddleName.TabIndex = 39;
            this.txtMiddleName.Text = "  Enter Middle Name Here";
            this.txtMiddleName.Visible = false;
            this.txtMiddleName.Enter += new System.EventHandler(this.txtMiddleName_Enter);
            this.txtMiddleName.Leave += new System.EventHandler(this.txtMiddleName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(277, 149);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(240, 25);
            this.txtFirstName.TabIndex = 40;
            this.txtFirstName.Text = "  Enter First Name Here";
            this.txtFirstName.Visible = false;
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
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
            this.btnSave.Location = new System.Drawing.Point(277, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 53);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "      Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 118;
            this.iconPictureBox1.Location = new System.Drawing.Point(302, 25);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(214, 118);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 46;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Visible = false;
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
            this.btnBack.Location = new System.Drawing.Point(545, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 34);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnDeposit_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdate.IconColor = System.Drawing.Color.AliceBlue;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 40;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.Location = new System.Drawing.Point(277, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(240, 53);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "      Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Gray;
            this.txtBalance.Location = new System.Drawing.Point(277, 225);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(240, 25);
            this.txtBalance.TabIndex = 38;
            this.txtBalance.Text = "  Enter Amount Here";
            this.txtBalance.Visible = false;
            this.txtBalance.Enter += new System.EventHandler(this.txtBalance_Enter);
            this.txtBalance.Leave += new System.EventHandler(this.txtBalance_Leave);
            // 
            // pnlBalanceShadow
            // 
            this.pnlBalanceShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBalanceShadow.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBalanceShadow.Location = new System.Drawing.Point(277, 252);
            this.pnlBalanceShadow.Name = "pnlBalanceShadow";
            this.pnlBalanceShadow.Size = new System.Drawing.Size(240, 1);
            this.pnlBalanceShadow.TabIndex = 42;
            this.pnlBalanceShadow.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(466, 199);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 23);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Registered on : ";
            this.lblDate.Visible = false;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransaction.ColumnHeadersHeight = 41;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransaction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.dgvTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgvTransaction.MultiSelect = false;
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.NullValue = "Not Set";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "Not Set";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransaction.RowTemplate.Height = 25;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(448, 396);
            this.dgvTransaction.TabIndex = 27;
            this.dgvTransaction.Visible = false;
            // 
            // btnTransactionBack
            // 
            this.btnTransactionBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransactionBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(125)))));
            this.btnTransactionBack.FlatAppearance.BorderSize = 0;
            this.btnTransactionBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnTransactionBack.IconColor = System.Drawing.Color.Black;
            this.btnTransactionBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransactionBack.IconSize = 25;
            this.btnTransactionBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTransactionBack.Location = new System.Drawing.Point(564, 386);
            this.btnTransactionBack.Name = "btnTransactionBack";
            this.btnTransactionBack.Size = new System.Drawing.Size(110, 34);
            this.btnTransactionBack.TabIndex = 9;
            this.btnTransactionBack.Text = "Back";
            this.btnTransactionBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactionBack.UseVisualStyleBackColor = false;
            this.btnTransactionBack.Visible = false;
            this.btnTransactionBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnTransactionBack.MouseEnter += new System.EventHandler(this.btnDeposit_MouseEnter);
            this.btnTransactionBack.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.pnlBalanceShadow);
            this.Controls.Add(this.pnlLastNameShadow);
            this.Controls.Add(this.pnlMiddleNameShadow);
            this.Controls.Add(this.pnlFirstNameShadow);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUserDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUserBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.dgvNameList);
            this.Controls.Add(this.pnlSearchShadow);
            this.Controls.Add(this.btnTransactionBack);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUserSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNameList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Panel pnlSearchShadow;
        private System.Windows.Forms.DataGridView dgvNameList;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblUserId;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblUserBalance;
        public System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.Label lblUserDate;
        public FontAwesome.Sharp.IconButton btnClear;
        public FontAwesome.Sharp.IconButton btnRemove;
        public FontAwesome.Sharp.IconButton btnEdit;
        public FontAwesome.Sharp.IconButton btnHistory;
        public FontAwesome.Sharp.IconButton btnDeposit;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Panel pnlLastNameShadow;
        private System.Windows.Forms.Panel pnlMiddleNameShadow;
        private System.Windows.Forms.Panel pnlFirstNameShadow;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Panel pnlBalanceShadow;
        public System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvTransaction;
        public FontAwesome.Sharp.IconButton btnTransactionBack;
    }
}