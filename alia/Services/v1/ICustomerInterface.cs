using alia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alia.Services.v1
{
    public interface ICustomerinterface
    {
        public interface ICustomerInterface
        {
            List<Customers> GetCustomers();
            Customers CreateCustomer(Customers cust);
            Customers DeleteCustomers(int id);

        }
    }

}