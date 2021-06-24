using alia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alia.Services.v1
{
    public  interface IAdminInterface
    {
        List<Admin> GetAdmin();
        Customers CreateAdmin(Admin A);
        Customers DeleteAdmin(int id);

    }
}
