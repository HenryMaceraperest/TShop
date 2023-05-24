namespace TShop.Views
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabUsersManagement = new System.Windows.Forms.TabControl();
            this.allUsers = new System.Windows.Forms.TabPage();
            this.editUsers = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.userListGV = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ageLimitGroupBox = new System.Windows.Forms.GroupBox();
            this.ageLimitRadioButton = new System.Windows.Forms.RadioButton();
            this.ageLimitRadioButton2 = new System.Windows.Forms.RadioButton();
            this.productTypeCombobox = new System.Windows.Forms.ComboBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.productBarcodeText = new System.Windows.Forms.TextBox();
            this.userIdText = new System.Windows.Forms.TextBox();
            this.productBarcodeLabel = new System.Windows.Forms.Label();
            this.productCostNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.productQuantityCombobox = new System.Windows.Forms.ComboBox();
            this.productCostLabel = new System.Windows.Forms.Label();
            this.productAgeLimitLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.tabUsersManagement.SuspendLayout();
            this.allUsers.SuspendLayout();
            this.editUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListGV)).BeginInit();
            this.ageLimitGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCostNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.headerPanel.Controls.Add(this.button1);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(970, 61);
            this.headerPanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(1706, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 39);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 622);
            this.panel1.TabIndex = 1;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(440, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(71, 32);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Users";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(920, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabUsersManagement
            // 
            this.tabUsersManagement.Controls.Add(this.allUsers);
            this.tabUsersManagement.Controls.Add(this.editUsers);
            this.tabUsersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabUsersManagement.Location = new System.Drawing.Point(0, 61);
            this.tabUsersManagement.Name = "tabUsersManagement";
            this.tabUsersManagement.SelectedIndex = 0;
            this.tabUsersManagement.Size = new System.Drawing.Size(970, 524);
            this.tabUsersManagement.TabIndex = 2;
            // 
            // allUsers
            // 
            this.allUsers.BackColor = System.Drawing.Color.Honeydew;
            this.allUsers.Controls.Add(this.userListGV);
            this.allUsers.Controls.Add(this.deleteButton);
            this.allUsers.Controls.Add(this.editButton);
            this.allUsers.Controls.Add(this.addButton);
            this.allUsers.Controls.Add(this.searchButton);
            this.allUsers.Controls.Add(this.labelSearch);
            this.allUsers.Controls.Add(this.searchTextBox);
            this.allUsers.Location = new System.Drawing.Point(4, 24);
            this.allUsers.Name = "allUsers";
            this.allUsers.Padding = new System.Windows.Forms.Padding(3);
            this.allUsers.Size = new System.Drawing.Size(962, 496);
            this.allUsers.TabIndex = 0;
            this.allUsers.Text = "All Users";
            // 
            // editUsers
            // 
            this.editUsers.BackColor = System.Drawing.Color.Honeydew;
            this.editUsers.Controls.Add(this.cancelButton);
            this.editUsers.Controls.Add(this.ageLimitGroupBox);
            this.editUsers.Controls.Add(this.productTypeCombobox);
            this.editUsers.Controls.Add(this.userNameText);
            this.editUsers.Controls.Add(this.productBarcodeText);
            this.editUsers.Controls.Add(this.userIdText);
            this.editUsers.Controls.Add(this.productBarcodeLabel);
            this.editUsers.Controls.Add(this.productCostNumbericUpDown);
            this.editUsers.Controls.Add(this.saveButton);
            this.editUsers.Controls.Add(this.productQuantityCombobox);
            this.editUsers.Controls.Add(this.productCostLabel);
            this.editUsers.Controls.Add(this.productAgeLimitLabel);
            this.editUsers.Controls.Add(this.productQuantityLabel);
            this.editUsers.Controls.Add(this.productTypeLabel);
            this.editUsers.Controls.Add(this.productNameLabel);
            this.editUsers.Controls.Add(this.productIdLabel);
            this.editUsers.Location = new System.Drawing.Point(4, 24);
            this.editUsers.Name = "editUsers";
            this.editUsers.Padding = new System.Windows.Forms.Padding(3);
            this.editUsers.Size = new System.Drawing.Size(962, 496);
            this.editUsers.TabIndex = 1;
            this.editUsers.Text = "Edit User";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(841, 262);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 48);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(841, 192);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 46);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(841, 121);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 48);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(685, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 51);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(6, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(142, 32);
            this.labelSearch.TabIndex = 8;
            this.labelSearch.Text = "Search user:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(17, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(640, 50);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userListGV
            // 
            this.userListGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userListGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userListGV.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userListGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userListGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.userListGV.Location = new System.Drawing.Point(17, 121);
            this.userListGV.Name = "userListGV";
            this.userListGV.ReadOnly = true;
            this.userListGV.RowTemplate.Height = 25;
            this.userListGV.Size = new System.Drawing.Size(803, 365);
            this.userListGV.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(278, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(206, 67);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ageLimitGroupBox
            // 
            this.ageLimitGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLimitGroupBox.Controls.Add(this.ageLimitRadioButton);
            this.ageLimitGroupBox.Controls.Add(this.ageLimitRadioButton2);
            this.ageLimitGroupBox.Location = new System.Drawing.Point(35, 297);
            this.ageLimitGroupBox.Name = "ageLimitGroupBox";
            this.ageLimitGroupBox.Size = new System.Drawing.Size(323, 77);
            this.ageLimitGroupBox.TabIndex = 31;
            this.ageLimitGroupBox.TabStop = false;
            // 
            // ageLimitRadioButton
            // 
            this.ageLimitRadioButton.AutoSize = true;
            this.ageLimitRadioButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLimitRadioButton.Location = new System.Drawing.Point(6, 22);
            this.ageLimitRadioButton.Name = "ageLimitRadioButton";
            this.ageLimitRadioButton.Size = new System.Drawing.Size(84, 49);
            this.ageLimitRadioButton.TabIndex = 13;
            this.ageLimitRadioButton.Text = "Yes";
            this.ageLimitRadioButton.UseVisualStyleBackColor = true;
            // 
            // ageLimitRadioButton2
            // 
            this.ageLimitRadioButton2.AutoSize = true;
            this.ageLimitRadioButton2.Checked = true;
            this.ageLimitRadioButton2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLimitRadioButton2.Location = new System.Drawing.Point(151, 22);
            this.ageLimitRadioButton2.Name = "ageLimitRadioButton2";
            this.ageLimitRadioButton2.Size = new System.Drawing.Size(81, 49);
            this.ageLimitRadioButton2.TabIndex = 14;
            this.ageLimitRadioButton2.TabStop = true;
            this.ageLimitRadioButton2.Text = "No";
            this.ageLimitRadioButton2.UseVisualStyleBackColor = true;
            // 
            // productTypeCombobox
            // 
            this.productTypeCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeCombobox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTypeCombobox.FormattingEnabled = true;
            this.productTypeCombobox.Items.AddRange(new object[] {
            "Fruit",
            "Dairy",
            "Produce",
            "Sweets",
            "Drinks"});
            this.productTypeCombobox.Location = new System.Drawing.Point(594, 161);
            this.productTypeCombobox.Name = "productTypeCombobox";
            this.productTypeCombobox.Size = new System.Drawing.Size(329, 53);
            this.productTypeCombobox.TabIndex = 29;
            // 
            // userNameText
            // 
            this.userNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameText.Location = new System.Drawing.Point(35, 164);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(528, 50);
            this.userNameText.TabIndex = 28;
            // 
            // productBarcodeText
            // 
            this.productBarcodeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productBarcodeText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productBarcodeText.Location = new System.Drawing.Point(453, 51);
            this.productBarcodeText.Name = "productBarcodeText";
            this.productBarcodeText.Size = new System.Drawing.Size(470, 50);
            this.productBarcodeText.TabIndex = 27;
            // 
            // userIdText
            // 
            this.userIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userIdText.Location = new System.Drawing.Point(35, 51);
            this.userIdText.Name = "userIdText";
            this.userIdText.ReadOnly = true;
            this.userIdText.Size = new System.Drawing.Size(323, 50);
            this.userIdText.TabIndex = 26;
            this.userIdText.Text = "0";
            // 
            // productBarcodeLabel
            // 
            this.productBarcodeLabel.AutoSize = true;
            this.productBarcodeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productBarcodeLabel.Location = new System.Drawing.Point(453, 3);
            this.productBarcodeLabel.Name = "productBarcodeLabel";
            this.productBarcodeLabel.Size = new System.Drawing.Size(262, 45);
            this.productBarcodeLabel.TabIndex = 25;
            this.productBarcodeLabel.Text = "Product Barcode:";
            // 
            // productCostNumbericUpDown
            // 
            this.productCostNumbericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCostNumbericUpDown.DecimalPlaces = 2;
            this.productCostNumbericUpDown.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCostNumbericUpDown.Location = new System.Drawing.Point(719, 313);
            this.productCostNumbericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productCostNumbericUpDown.Name = "productCostNumbericUpDown";
            this.productCostNumbericUpDown.Size = new System.Drawing.Size(204, 50);
            this.productCostNumbericUpDown.TabIndex = 34;
            this.productCostNumbericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(35, 403);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(206, 67);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // productQuantityCombobox
            // 
            this.productQuantityCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productQuantityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productQuantityCombobox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantityCombobox.FormattingEnabled = true;
            this.productQuantityCombobox.Items.AddRange(new object[] {
            "Lbs",
            "Litre",
            "Pack",
            "Piece",
            "Can",
            "Bottle",
            "Box"});
            this.productQuantityCombobox.Location = new System.Drawing.Point(398, 313);
            this.productQuantityCombobox.Name = "productQuantityCombobox";
            this.productQuantityCombobox.Size = new System.Drawing.Size(261, 53);
            this.productQuantityCombobox.TabIndex = 30;
            // 
            // productCostLabel
            // 
            this.productCostLabel.AutoSize = true;
            this.productCostLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCostLabel.Location = new System.Drawing.Point(719, 249);
            this.productCostLabel.Name = "productCostLabel";
            this.productCostLabel.Size = new System.Drawing.Size(204, 45);
            this.productCostLabel.TabIndex = 24;
            this.productCostLabel.Text = "Product Cost";
            // 
            // productAgeLimitLabel
            // 
            this.productAgeLimitLabel.AutoSize = true;
            this.productAgeLimitLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAgeLimitLabel.Location = new System.Drawing.Point(35, 249);
            this.productAgeLimitLabel.Name = "productAgeLimitLabel";
            this.productAgeLimitLabel.Size = new System.Drawing.Size(335, 45);
            this.productAgeLimitLabel.TabIndex = 23;
            this.productAgeLimitLabel.Text = "Product has age limit?";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantityLabel.Location = new System.Drawing.Point(398, 249);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(261, 45);
            this.productQuantityLabel.TabIndex = 22;
            this.productQuantityLabel.Text = "Product Quantity";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTypeLabel.Location = new System.Drawing.Point(593, 113);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(213, 45);
            this.productTypeLabel.TabIndex = 21;
            this.productTypeLabel.Text = "Product Type:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(35, 116);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(232, 45);
            this.productNameLabel.TabIndex = 20;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdLabel.Location = new System.Drawing.Point(35, 3);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(178, 45);
            this.productIdLabel.TabIndex = 19;
            this.productIdLabel.Text = "Product ID:";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(970, 589);
            this.Controls.Add(this.tabUsersManagement);
            this.Controls.Add(this.headerPanel);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.tabUsersManagement.ResumeLayout(false);
            this.allUsers.ResumeLayout(false);
            this.allUsers.PerformLayout();
            this.editUsers.ResumeLayout(false);
            this.editUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListGV)).EndInit();
            this.ageLimitGroupBox.ResumeLayout(false);
            this.ageLimitGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCostNumbericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Button closeButton;
        private Panel panel1;
        private Label headerLabel;
        private Button button1;
        private TabControl tabUsersManagement;
        private TabPage allUsers;
        private TabPage editUsers;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Button searchButton;
        private Label labelSearch;
        private TextBox searchTextBox;
        private DataGridView userListGV;
        private Button cancelButton;
        private GroupBox ageLimitGroupBox;
        private RadioButton ageLimitRadioButton;
        private RadioButton ageLimitRadioButton2;
        private ComboBox productTypeCombobox;
        private TextBox userNameText;
        private TextBox productBarcodeText;
        private TextBox userIdText;
        private Label productBarcodeLabel;
        private NumericUpDown productCostNumbericUpDown;
        private Button saveButton;
        private ComboBox productQuantityCombobox;
        private Label productCostLabel;
        private Label productAgeLimitLabel;
        private Label productQuantityLabel;
        private Label productTypeLabel;
        private Label productNameLabel;
        private Label productIdLabel;
    }
}