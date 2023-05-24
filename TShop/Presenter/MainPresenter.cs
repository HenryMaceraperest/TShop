using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Views;
using TShop.Models;
using TShop._Repositories;

namespace TShop.Presenter
{
    internal class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowManageUsersView += ShowManageUsersView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowLoginView += ShowLoginView;
        }

        private void ShowLoginView(object? sender, EventArgs e)
        {
            ILoginView view = loginScreen.GetInstance((MainView)mainView);
            ILoginRepository repository = new LoginRepository(sqlConnectionString);
            new LoginPresenter(view, repository);
        }

        private void ShowManageUsersView(object? sender, EventArgs e)
        {
            IManageUsersView view = ManageUsers.GetInstance((MainView)mainView);
            IManageUsersRepository repository = new ManageUsersRepository(sqlConnectionString);
            new ManageUsersPresenter(view, repository);
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView view = ProductForm.GetInstance((MainView)mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }
    }
}
