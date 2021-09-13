using Npgsql;
using PetDiscovery.IDAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;

namespace PetDiscovery.DAO
{
    class FoundedPetsDao : IFoundedPets
    {
        DaoFactory connection = new DaoFactory();
        NpgsqlCommand cmd = new NpgsqlCommand();
        String message = "";

        public void DeleteFoundedPets(FoundedPets founded)
        {
            throw new NotImplementedException();
        }

        public List<FoundedPets> GetAllFoundedPets()
        {
            throw new NotImplementedException();
        }

        public FoundedPets GetFoundedPets(int rollNo)
        {
            throw new NotImplementedException();
        }

        public void InsertFoundedPets(FoundedPets founded)
        {
            throw new NotImplementedException();
        }

        public void UpdateFoundedPets(FoundedPets founded)
        {
            throw new NotImplementedException();
        }
    }
}
