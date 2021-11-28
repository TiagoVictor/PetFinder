using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery.IDAO
{
    interface IAnimals
    {
        public List<Animals> GetAnimals();

        public List<Animals> CompativeAnimals(Animals animals);

        public int Update(Animals animals);

        public int Insert(Animals animals, LogedUser loged);

        public int Delete(Animals animals);
    }
}
