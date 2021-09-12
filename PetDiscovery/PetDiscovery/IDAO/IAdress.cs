using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.IDAO
{
    interface IAdress
    {
        public List<Adress> GetAllAdress();
        public Adress GetAdress(int rollNo);
        public void UpdateAdress(Adress adress);
        public void DeleteAdress(Adress adress);
        public void InsertAdress(Adress adress);
    }
}
