using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery.IDAO
{
    interface IPositiveResults
    {
        public List<PositiveResults> GetResults();

        public int InsertResult(PositiveResults positive);

        public int UpdateResult(PositiveResults positive);
    }
}
