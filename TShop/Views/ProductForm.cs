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
    public partial class ProductForm : Form, IProductView
    {
        // Fields
        private string message;
        private bool isSuccessful;
        private bool isEdited;

        // Constructor
        public ProductForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            mainProductTab.TabPages.Remove(detailTab);
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
                mainProductTab.TabPages.Remove(listTab);
                mainProductTab.TabPages.Add(detailTab);
                headerLabel.Text = "Add a new Product";
            };

            // Edit Product functionality
            editButton.Click += delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                mainProductTab.TabPages.Remove(listTab);
                mainProductTab.TabPages.Add(detailTab);
                headerLabel.Text = "Edit a Product";
            };

            // Save a Product functionality
            saveButton.Click += delegate 
            {
                SaveEvent?.Invoke(this, EventArgs.Empty); 
                if (isSuccessful)
                {
                    mainProductTab.TabPages.Remove(detailTab);
                    mainProductTab.TabPages.Add(listTab);
                    headerLabel.Text = "Products";
                }
                MessageBox.Show(Message);
            };

            // Delete a Product functionality
            deleteButton.Click += delegate 
            {
                var result = MessageBox.Show("Are you sure you want to delete the product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                mainProductTab.TabPages.Remove(detailTab);
                mainProductTab.TabPages.Add(listTab);
            };

        }

        // Properties
        public string ProductId 
        {
            get { return productIdText.Text; }
            set { productIdText.Text = value; }
        }
        public string ProductName 
        {
            get { return productNameText.Text; }
            set { productNameText.Text = value; }
        }
        public string ProductType 
        {
            get { return productTypeCombobox.Text; }
            set { productTypeCombobox.Text = value; }
        }
        public string ProductQuantity 
        {
            get { return productQuantityCombobox.Text; }
            set { productQuantityCombobox.Text = value; }
        }
        public bool ProductAgeLimit 
        {
            get
            {
                if (ageLimitRadioButton.Checked == true)
                {
                    return true;
                }
                return false;
            }
            set 
            {
                if (value == true) {ageLimitRadioButton.Checked = true; ageLimitRadioButton2.Checked = false; }
                else { ageLimitRadioButton.Checked = false; ageLimitRadioButton2.Checked = true; }
            }
        }
        public long ProductBarcode 
        {
            get { return long.TryParse(productBarcodeText.Text, out _) ? Convert.ToInt64(productBarcodeText.Text) : 0; }
            set { productBarcodeText.Text = value.ToString(); }
        }
        public decimal ProductCost 
        {
            get { return productCostNumbericUpDown.Value; }
            set { productCostNumbericUpDown.Value = value; } 
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
            set { message = value;  } 
        }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods

        public void SetProductListBindingSource(BindingSource productList)
        {
            productListGV.DataSource = productList;
        }

        // Singleton
        private static ProductForm instance;
        public static ProductForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductForm();
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
