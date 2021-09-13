using Npgsql;
using PetDiscovery.IDAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;

namespace PetDiscovery.DAO
{
    class LostPetsDao : ILostPets
    {
        DaoFactory connection = new DaoFactory();
        NpgsqlCommand cmd = new NpgsqlCommand();
        String message = "";

        public void DeleteLostPets(LostPets lost)
        {
            throw new NotImplementedException();
        }

        public List<LostPets> GetAllLostPets()
        {
            throw new NotImplementedException();
        }

        public LostPets GetLostPets(int rollNo)
        {
            throw new NotImplementedException();
        }

        public void InsertLostPets(LostPets lost)
        {
            throw new NotImplementedException();
        }

        public void UpdateLostPets(LostPets lost)
        {
            throw new NotImplementedException();
        }
    }
}
