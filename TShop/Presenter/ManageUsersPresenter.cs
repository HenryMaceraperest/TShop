using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Models;
using TShop.Views;

namespace TShop.Presenter
{
    internal class ManageUsersPresenter
    {
        private IManageUsersView view;
        private IManageUsersRepository repository;
        private BindingSource userBindingSource;
        private IEnumerable<UserModel> userList;

        // Constructor
        public ManageUsersPresenter(IManageUsersView view, IManageUsersRepository repository)
        {
            this.view = view;
            this.repository = repository;
            // Subscribe event handler methods to view events

            this.view.SearchEvent += SearchUser;
            this.view.AddNewEvent += AddNewUser;
            this.view.EditEvent += EditUser;
            this.view.DeleteEvent += DeleteSelectedUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            // Set product binding source
            this.view.SetUserListBindingSource(userBindingSource);
            // Load product list view
            LoadAllUsers();
            // Show view
            this.view.Show();

        }

        private void LoadAllUsers()
        {
            userList = repository.GetAll();
            userBindingSource.DataSource = userList;
        }

        private void SearchUser(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                userList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                userList = repository.GetAll();
            }
            userBindingSource.DataSource = userList;
        }

        private void AddNewUser(object? sender, EventArgs e)
        {
            view.IsEdited = false;
        }

        private void EditUser(object? sender, EventArgs e)
        {
            var user = (UserModel)userBindingSource.Current;
            view.UserId = user.Id.ToString();
            view.UserName = user.Username;
            view.IsEdited = true;
        }

        private void SaveUser(object? sender, EventArgs e)
        {
            var model = new UserModel();
            model.Id = Convert.ToInt32(view.UserId);
            model.Username = view.UserName;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdited)
                {
                    repository.Edit(model);
                    view.Message = "Edit saved successfully!";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Successfully added new user!";
                }
                view.IsSuccessful = true;
                LoadAllUsers();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.UserId = "0";
            view.UserName = "";
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedUser(object? sender, EventArgs e)
        {
            try
            {
                var user = (UserModel)userBindingSource.Current;
                repository.Delete(Convert.ToInt32(user.Id));
                view.IsSuccessful = true;
                view.Message = "User deleted successfully!";
                LoadAllUsers();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error! Could not delete the user!";
            }
        }
    }
}
