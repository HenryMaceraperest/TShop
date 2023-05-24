using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Views
{
    internal interface ILoginView
    {
        // Properties
        string Username { get; set; }
        string Password { get; set; }

        // Events
        event EventHandler LoginEvent;
        void Show();
    }
}
