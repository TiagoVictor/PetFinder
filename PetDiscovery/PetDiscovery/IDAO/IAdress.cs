using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.IDAO
{
    interface IAdress
    {
        public List<Adress> GetAllAdress();
        public Adress GetAdress(int rollNo);
        public int UpdateAdress(Adress adress);
        public int DeleteAdress(Adress adress);
        public int InsertAdress(Adress adress, LogedUser loged);
    }
}
