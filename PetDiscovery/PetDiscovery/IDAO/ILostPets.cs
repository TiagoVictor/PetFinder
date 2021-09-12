using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.IDAO
{
    interface ILostPets
    {
        public List<LostPets> GetAllLostPets();
        public LostPets GetLostPets(int rollNo);
        public void UpdateLostPets(LostPets lost);
        public void DeleteLostPets(LostPets lost);
        public void InsertLostPets(LostPets lost);
    }
}
