using PetDiscovery.DAO;
using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.Controller
{
    public class CustomerController
    {
        CustomerDao cd = new CustomerDao();
        AnimalsDao ad = new AnimalsDao();
        AdressDao ed = new AdressDao();

        public void Insert (Customer customer)
        {
            cd.InsertCustomer(customer);
        }

        public void Update (Customer customer)
        {
            cd.UpdateCustomer(customer);
        }

        public void Delete (Customer customer)
        {
            cd.DeleteCustomer(customer);
        }

        public void List (Customer customer)
        {

        }

        public void CreateAnimal (LogedUser loged, Animals animals)
        {
            List<Animals> compativeLst = new List<Animals>();

            ad.Insert(animals, loged);
            compativeLst = ad.CompativeAnimals(animals);

            foreach (var anm in compativeLst)
            {
                if (animals.CityAnimal != anm.CityAnimal)
                {
                    compativeLst.Remove(anm);
                }
                else if (animals.NeigherborAnimal != anm.NeigherborAnimal)
                {
                    compativeLst.Remove(anm);
                }
                else if (animals.UfAnimal != anm.UfAnimal)
                {
                    compativeLst.Remove(anm);
                }
            }

            if (compativeLst.Count > 0)
            {
                
            }
        }

        public void CreateAdress (LogedUser loged, Adress adress)
        {
            ed.InsertAdress(adress, loged);
        }
    }
}
