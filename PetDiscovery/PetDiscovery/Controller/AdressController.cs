using PetDiscovery.DAO;
using PetDiscovery.Model;

namespace PetDiscovery.Controller
{
    public class AdressController
    {

        AdressDao ad = new AdressDao();

        public void Insert(Adress adress, LogedUser loged)
        {
            ad.InsertAdress(adress, loged);
        }

        public void Update(Adress adress)
        {
            ad.UpdateAdress(adress);
        }

        public void Delete(Adress adress)
        {
            ad.DeleteAdress(adress);
        }
    }
}
