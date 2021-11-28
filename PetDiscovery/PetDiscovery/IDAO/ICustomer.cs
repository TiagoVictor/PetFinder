using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.IDAO
{
    interface ICustomer
    {
        public Customer GetCustomer(string email, string password);
        public int UpdateCustomer(Customer customer);
        public int DeleteCustomer(Customer customer);
        public int InsertCustomer(Customer customer);
    }
}
