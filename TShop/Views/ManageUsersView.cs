using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShop.Views
{
    public partial class ManageUsers : Form, IManageUsersView
    {
        // Fields
        private string message;
        private bool isSuccessful;
        private bool isEdited;
        public ManageUsers()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabUsersManagement.TabPages.Remove(editUsers);
            closeButton.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search functionality
            searchButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchTextBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Add new Product functionality
            addButton.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabUsersManagement.TabPages.Remove(allUsers);
                tabUsersManagement.TabPages.Add(editUsers);
                headerLabel.Text = "Add a new User";
            };

            // Edit Product functionality
            editButton.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabUsersManagement.TabPages.Remove(allUsers);
                tabUsersManagement.TabPages.Add(editUsers);
                headerLabel.Text = "Edit a User";
            };

            // Save a Product functionality
            saveButton.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabUsersManagement.TabPages.Remove(editUsers);
                    tabUsersManagement.TabPages.Add(allUsers);
                    headerLabel.Text = "Users";
                }
                MessageBox.Show(Message);
            };

            // Delete a Product functionality
            deleteButton.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Cancel changing/adding the Product functionality
            cancelButton.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabUsersManagement.TabPages.Remove(editUsers);
                tabUsersManagement.TabPages.Add(allUsers);
            };

        }

        //Properties
        public string UserId
        {
            get { return userIdText.Text; }
            set { userIdText.Text = value; }
        }
        public string UserName
        {
            get { return userNameText.Text; }
            set { userNameText.Text = value; }
        }

        public string SearchValue
        {
            get { return searchTextBox.Text; }
            set { searchTextBox.Text = value; }
        }
        public bool IsEdited
        {
            get { return isEdited; }
            set { isEdited = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods

        public void SetUserListBindingSource(BindingSource userList)
        {
            userListGV.DataSource = userList;
        }

        // Singleton
        private static ManageUsers instance;
        public static ManageUsers GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ManageUsers();
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

    }
}
