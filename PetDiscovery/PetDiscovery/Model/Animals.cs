using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery.Model
{
    public class Animals
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FoundAndLostFlag { get; set; }

        public bool KeepSearching { get; set; }

        public int CustomerId { get; set; }

        public string Type { get; set; }

        public string Breed { get; set; }

        public string UfAnimal { get; set; }

        public string CityAnimal { get; set; }

        public string NeigherborAnimal { get; set; }

        public string StreetAnimal { get; set; }

        public int Distance { get; set; }
    }
}
