using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Views
{
    public interface IMainView
    {
        event EventHandler ShowProductView;
        event EventHandler ShowCashierView;
        event EventHandler ShowManageUsersView;
        event EventHandler ShowLoginView;
    }
}
