using PetDiscovery.DAO;
using PetDiscovery.Model;
using System;

namespace PetDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDao cd = new CustomerDao();
            Customer c = new Customer();

            try
            {
                c.Id = 1;
                c.Name = "Teste";
                c.Email = "tiagovictordeoliveira@gmail.com";

                cd.InsertCustomer(c);

                c.Name = "Juca da balita";
                cd.UpdateCustomer(c);
            }
            catch
            {
                Console.WriteLine("Deu pau");
            }
        }
    }
}
