namespace TShop.Views
{
    partial class ProductForm
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mainProductTab = new System.Windows.Forms.TabControl();
            this.listTab = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productListGV = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.detailTab = new System.Windows.Forms.TabPage();
            this.productCostNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ageLimitGroupBox = new System.Windows.Forms.GroupBox();
            this.ageLimitRadioButton = new System.Windows.Forms.RadioButton();
            this.ageLimitRadioButton2 = new System.Windows.Forms.RadioButton();
            this.productQuantityCombobox = new System.Windows.Forms.ComboBox();
            this.productTypeCombobox = new System.Windows.Forms.ComboBox();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productBarcodeText = new System.Windows.Forms.TextBox();
            this.productIdText = new System.Windows.Forms.TextBox();
            this.productBarcodeLabel = new System.Windows.Forms.Label();
            this.productCostLabel = new System.Windows.Forms.Label();
            this.productAgeLimitLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainProductTab.SuspendLayout();
            this.listTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListGV)).BeginInit();
            this.detailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCostNumbericUpDown)).BeginInit();
            this.ageLimitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(986, 61);
            this.headerPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(936, 13);
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
            this.headerLabel.Location = new System.Drawing.Point(408, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(106, 32);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Products";
            // 
            // mainProductTab
            // 
            this.mainProductTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProductTab.Controls.Add(this.listTab);
            this.mainProductTab.Controls.Add(this.detailTab);
            this.mainProductTab.Location = new System.Drawing.Point(0, 61);
            this.mainProductTab.Name = "mainProductTab";
            this.mainProductTab.SelectedIndex = 0;
            this.mainProductTab.Size = new System.Drawing.Size(986, 628);
            this.mainProductTab.TabIndex = 2;
            // 
            // listTab
            // 
            this.listTab.BackColor = System.Drawing.Color.Honeydew;
            this.listTab.Controls.Add(this.deleteButton);
            this.listTab.Controls.Add(this.editButton);
            this.listTab.Controls.Add(this.addButton);
            this.listTab.Controls.Add(this.productListGV);
            this.listTab.Controls.Add(this.searchButton);
            this.listTab.Controls.Add(this.searchLabel);
            this.listTab.Controls.Add(this.searchTextBox);
            this.listTab.Location = new System.Drawing.Point(4, 24);
            this.listTab.Name = "listTab";
            this.listTab.Padding = new System.Windows.Forms.Padding(3);
            this.listTab.Size = new System.Drawing.Size(978, 600);
            this.listTab.TabIndex = 0;
            this.listTab.Text = "Product List";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(856, 250);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 48);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(856, 181);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 46);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(856, 112);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 48);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // productListGV
            // 
            this.productListGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productListGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productListGV.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productListGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productListGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productListGV.Location = new System.Drawing.Point(21, 112);
            this.productListGV.Name = "productListGV";
            this.productListGV.ReadOnly = true;
            this.productListGV.RowTemplate.Height = 25;
            this.productListGV.Size = new System.Drawing.Size(811, 447);
            this.productListGV.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(697, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 51);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(21, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(180, 32);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search product:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(21, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(637, 50);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailTab
            // 
            this.detailTab.Controls.Add(this.productCostNumbericUpDown);
            this.detailTab.Controls.Add(this.cancelButton);
            this.detailTab.Controls.Add(this.saveButton);
            this.detailTab.Controls.Add(this.ageLimitGroupBox);
            this.detailTab.Controls.Add(this.productQuantityCombobox);
            this.detailTab.Controls.Add(this.productTypeCombobox);
            this.detailTab.Controls.Add(this.productNameText);
            this.detailTab.Controls.Add(this.productBarcodeText);
            this.detailTab.Controls.Add(this.productIdText);
            this.detailTab.Controls.Add(this.productBarcodeLabel);
            this.detailTab.Controls.Add(this.productCostLabel);
            this.detailTab.Controls.Add(this.productAgeLimitLabel);
            this.detailTab.Controls.Add(this.productQuantityLabel);
            this.detailTab.Controls.Add(this.productTypeLabel);
            this.detailTab.Controls.Add(this.productNameLabel);
            this.detailTab.Controls.Add(this.productIdLabel);
            this.detailTab.Location = new System.Drawing.Point(4, 24);
            this.detailTab.Name = "detailTab";
            this.detailTab.Padding = new System.Windows.Forms.Padding(3);
            this.detailTab.Size = new System.Drawing.Size(978, 600);
            this.detailTab.TabIndex = 1;
            this.detailTab.Text = "Product Detail";
            this.detailTab.UseVisualStyleBackColor = true;
            // 
            // productCostNumbericUpDown
            // 
            this.productCostNumbericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCostNumbericUpDown.DecimalPlaces = 2;
            this.productCostNumbericUpDown.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCostNumbericUpDown.Location = new System.Drawing.Point(718, 341);
            this.productCostNumbericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.productCostNumbericUpDown.Name = "productCostNumbericUpDown";
            this.productCostNumbericUpDown.Size = new System.Drawing.Size(204, 50);
            this.productCostNumbericUpDown.TabIndex = 18;
            this.productCostNumbericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(283, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(206, 67);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(34, 454);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(206, 67);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // ageLimitGroupBox
            // 
            this.ageLimitGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLimitGroupBox.Controls.Add(this.ageLimitRadioButton);
            this.ageLimitGroupBox.Controls.Add(this.ageLimitRadioButton2);
            this.ageLimitGroupBox.Location = new System.Drawing.Point(34, 325);
            this.ageLimitGroupBox.Name = "ageLimitGroupBox";
            this.ageLimitGroupBox.Size = new System.Drawing.Size(323, 77);
            this.ageLimitGroupBox.TabIndex = 15;
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
            this.productQuantityCombobox.Location = new System.Drawing.Point(397, 341);
            this.productQuantityCombobox.Name = "productQuantityCombobox";
            this.productQuantityCombobox.Size = new System.Drawing.Size(261, 53);
            this.productQuantityCombobox.TabIndex = 12;
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
            this.productTypeCombobox.Location = new System.Drawing.Point(593, 189);
            this.productTypeCombobox.Name = "productTypeCombobox";
            this.productTypeCombobox.Size = new System.Drawing.Size(329, 53);
            this.productTypeCombobox.TabIndex = 11;
            // 
            // productNameText
            // 
            this.productNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameText.Location = new System.Drawing.Point(34, 189);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(528, 50);
            this.productNameText.TabIndex = 9;
            // 
            // productBarcodeText
            // 
            this.productBarcodeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productBarcodeText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productBarcodeText.Location = new System.Drawing.Point(452, 79);
            this.productBarcodeText.Name = "productBarcodeText";
            this.productBarcodeText.Size = new System.Drawing.Size(470, 50);
            this.productBarcodeText.TabIndex = 8;
            // 
            // productIdText
            // 
            this.productIdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productIdText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdText.Location = new System.Drawing.Point(34, 79);
            this.productIdText.Name = "productIdText";
            this.productIdText.ReadOnly = true;
            this.productIdText.Size = new System.Drawing.Size(323, 50);
            this.productIdText.TabIndex = 7;
            this.productIdText.Text = "0";
            // 
            // productBarcodeLabel
            // 
            this.productBarcodeLabel.AutoSize = true;
            this.productBarcodeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productBarcodeLabel.Location = new System.Drawing.Point(452, 31);
            this.productBarcodeLabel.Name = "productBarcodeLabel";
            this.productBarcodeLabel.Size = new System.Drawing.Size(262, 45);
            this.productBarcodeLabel.TabIndex = 6;
            this.productBarcodeLabel.Text = "Product Barcode:";
            // 
            // productCostLabel
            // 
            this.productCostLabel.AutoSize = true;
            this.productCostLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCostLabel.Location = new System.Drawing.Point(718, 277);
            this.productCostLabel.Name = "productCostLabel";
            this.productCostLabel.Size = new System.Drawing.Size(204, 45);
            this.productCostLabel.TabIndex = 5;
            this.productCostLabel.Text = "Product Cost";
            // 
            // productAgeLimitLabel
            // 
            this.productAgeLimitLabel.AutoSize = true;
            this.productAgeLimitLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAgeLimitLabel.Location = new System.Drawing.Point(34, 277);
            this.productAgeLimitLabel.Name = "productAgeLimitLabel";
            this.productAgeLimitLabel.Size = new System.Drawing.Size(335, 45);
            this.productAgeLimitLabel.TabIndex = 4;
            this.productAgeLimitLabel.Text = "Product has age limit?";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantityLabel.Location = new System.Drawing.Point(397, 277);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(261, 45);
            this.productQuantityLabel.TabIndex = 3;
            this.productQuantityLabel.Text = "Product Quantity";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTypeLabel.Location = new System.Drawing.Point(592, 141);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(213, 45);
            this.productTypeLabel.TabIndex = 2;
            this.productTypeLabel.Text = "Product Type:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(34, 141);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(232, 45);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdLabel.Location = new System.Drawing.Point(34, 31);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(178, 45);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "Product ID:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 686);
            this.Controls.Add(this.mainProductTab);
            this.Controls.Add(this.headerPanel);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainProductTab.ResumeLayout(false);
            this.listTab.ResumeLayout(false);
            this.listTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListGV)).EndInit();
            this.detailTab.ResumeLayout(false);
            this.detailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCostNumbericUpDown)).EndInit();
            this.ageLimitGroupBox.ResumeLayout(false);
            this.ageLimitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Panel panel1;
        private Label headerLabel;
        private TabControl mainProductTab;
        private TabPage listTab;
        private Button searchButton;
        private Label searchLabel;
        private TextBox searchTextBox;
        private TabPage detailTab;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private DataGridView productListGV;
        private Label productTypeLabel;
        private Label productNameLabel;
        private Label productIdLabel;
        private Label productBarcodeLabel;
        private Label productCostLabel;
        private Label productAgeLimitLabel;
        private Label productQuantityLabel;
        private RadioButton ageLimitRadioButton2;
        private RadioButton ageLimitRadioButton;
        private ComboBox productQuantityCombobox;
        private ComboBox productTypeCombobox;
        private TextBox productNameText;
        private TextBox productBarcodeText;
        private TextBox productIdText;
        private Button cancelButton;
        private Button saveButton;
        private GroupBox ageLimitGroupBox;
        private NumericUpDown productCostNumbericUpDown;
        private Button closeButton;
    }
}