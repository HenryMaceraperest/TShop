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
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            showProductsButton.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            btnManageUsers.Click += delegate { ShowManageUsersView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowProductView;
        public event EventHandler ShowManageUsersView;
        public event EventHandler ShowCashierView;
        public event EventHandler ShowLoginView;
    }
}
