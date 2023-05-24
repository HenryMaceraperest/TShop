using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Models
{
    internal interface ILoginRepository
    {
        UserModel Login(UserModel user);
    }
}
