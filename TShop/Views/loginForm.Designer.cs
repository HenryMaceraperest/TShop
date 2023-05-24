namespace TShop
{
    partial class loginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.loginBGPanel = new System.Windows.Forms.Panel();
            this.shopLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.guestLoginLabel = new System.Windows.Forms.Label();
            this.loginFormPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            this.loginFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBGPanel
            // 
            this.loginBGPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBGPanel.BackColor = System.Drawing.Color.LightGreen;
            this.loginBGPanel.BackgroundImage = global::TShop.Properties.Resources.grocery_store;
            this.loginBGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBGPanel.Location = new System.Drawing.Point(342, 0);
            this.loginBGPanel.Name = "loginBGPanel";
            this.loginBGPanel.Size = new System.Drawing.Size(542, 441);
            this.loginBGPanel.TabIndex = 0;
            // 
            // shopLabel
            // 
            this.shopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shopLabel.AutoSize = true;
            this.shopLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.shopLabel.Location = new System.Drawing.Point(130, 20);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(98, 32);
            this.shopLabel.TabIndex = 1;
            this.shopLabel.Text = "TShop";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.usernameLabel.Location = new System.Drawing.Point(34, 211);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 18);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.passwordLabel.Location = new System.Drawing.Point(34, 255);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 18);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.usernameTextBox.Location = new System.Drawing.Point(130, 211);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(130, 23);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.passwordTextBox.Location = new System.Drawing.Point(130, 255);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(130, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Location = new System.Drawing.Point(155, 302);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // loginLogo
            // 
            this.loginLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLogo.Image = global::TShop.Properties.Resources.basket_cart;
            this.loginLogo.Location = new System.Drawing.Point(103, 77);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(157, 83);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginLogo.TabIndex = 7;
            this.loginLogo.TabStop = false;
            // 
            // guestLoginLabel
            // 
            this.guestLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guestLoginLabel.AutoSize = true;
            this.guestLoginLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.guestLoginLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.guestLoginLabel.Location = new System.Drawing.Point(141, 341);
            this.guestLoginLabel.Name = "guestLoginLabel";
            this.guestLoginLabel.Size = new System.Drawing.Size(99, 12);
            this.guestLoginLabel.TabIndex = 8;
            this.guestLoginLabel.Text = "Forgot Password";
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.Controls.Add(this.guestLoginLabel);
            this.loginFormPanel.Controls.Add(this.loginLogo);
            this.loginFormPanel.Controls.Add(this.loginButton);
            this.loginFormPanel.Controls.Add(this.passwordTextBox);
            this.loginFormPanel.Controls.Add(this.shopLabel);
            this.loginFormPanel.Controls.Add(this.usernameTextBox);
            this.loginFormPanel.Controls.Add(this.usernameLabel);
            this.loginFormPanel.Controls.Add(this.passwordLabel);
            this.loginFormPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(343, 441);
            this.loginFormPanel.TabIndex = 9;
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 441);
            this.Controls.Add(this.loginFormPanel);
            this.Controls.Add(this.loginBGPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TShop Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.loginFormPanel.ResumeLayout(false);
            this.loginFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginBGPanel;
        private Label shopLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private PictureBox loginLogo;
        private Label guestLoginLabel;
        private Panel loginFormPanel;
    }
}