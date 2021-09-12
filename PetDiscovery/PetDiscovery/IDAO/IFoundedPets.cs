using PetDiscovery.Model;
using System.Collections.Generic;

namespace PetDiscovery.IDAO
{
    interface IFoundedPets
    {
        public List<FoundedPets> GetAllFoundedPets();
        public FoundedPets GetFoundedPets(int rollNo);
        public void UpdateFoundedPets(FoundedPets founded);
        public void DeleteFoundedPets(FoundedPets founded);
        public void InsertFoundedPets(FoundedPets founded);
    }
}
