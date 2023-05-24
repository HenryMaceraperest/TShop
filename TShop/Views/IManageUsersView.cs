using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Views
{
    internal interface IManageUsersView
    {
        // Properties
        string UserId { get; set; }
        string UserName { get; set; }

        string SearchValue { get; set; }
        bool IsEdited { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetUserListBindingSource(BindingSource userList);

        void Show();
    }
}
