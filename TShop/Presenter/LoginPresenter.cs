using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Models;
using TShop.Views;

namespace TShop.Presenter
{
    internal class LoginPresenter
    {
        private ILoginView view;
        private ILoginRepository repository;

        // Constructor
        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            this.view = view;
            this.repository = repository;

            // Subscribe event handler methods to view events
            this.view.LoginEvent += UserLogin;

            // Show view
            this.view.Show();

        }

        private void UserLogin(object? sender, EventArgs e)
        {
            var model = new UserModel();
            model.Username = view.Username;
            model.Password = view.Password;
            repository.Login(model);
        }
    }
}
