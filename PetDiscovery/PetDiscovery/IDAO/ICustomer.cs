using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.IDAO
{
    interface ICustomer
    {
        public List<Customer> GetAllCustomer();
        public Customer GetCustomer(int rollNo);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);
        public void InsertCustomer(Customer customer);
    }
}
