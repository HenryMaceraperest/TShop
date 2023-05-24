using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Models
{
    internal class UserModel
    {
        private int id;
        private string userame;
        private string password;

        [DisplayName("User ID")]
        public int Id
        {
            get => id;
            set => id = value;
        }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username has to be longer than 3 characters!")]
        public string Username
        {
            get => userame;
            set => userame = value;
        }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password has to be longer than 3 characters!")]
        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}
