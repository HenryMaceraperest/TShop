using System.Data;
using System.Data.SqlClient;
using TShop._Repositories;
using TShop.Models;
using TShop.Presenter;
using TShop.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TShop
{
    public partial class loginScreen : Form, ILoginView
    {
        // Fields
        private string message;
        private bool isSuccessful;

        public loginScreen()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            loginButton.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            //closeButton.Click += delegate { this.Close(); };
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-95L7MVP\SQLEXPRESS01;Initial Catalog=TShop;Integrated Security=True");

        private void AssociateAndRaiseViewEvents()
        {
            // Login functionality
            loginButton.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
        }


        // Properties
        public string Username
        {
            get { return usernameTextBox.Text; }
            set { usernameTextBox.Text = value; }
        }
        public string Password
        {
            get { return passwordTextBox.Text; }
            set { passwordTextBox.Text = value; }
        }

        // Singleton
        private static loginScreen instance;
        public static loginScreen GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new loginScreen();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        // Events
        public event EventHandler LoginEvent;
    }
}