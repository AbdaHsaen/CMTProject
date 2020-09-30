using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMTLabs.DAL.ManagersBase;

namespace CMTLabs.DAL.LookupsManager
{
    public class LookupsManager : ManagerBase , ILookupsManager
    {
        public void AddNewLookups(List<LookupDTO> LookupDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteLookup(int LookupId)
        {
            throw new NotImplementedException();
        }

        public List<LookupDTO> GetAllLookupsByCategoryId(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public LookupDTO GetLookupById(int LookupId)
        {
            throw new NotImplementedException();
        }

        public string GetLookupCode(int lookupId)
        {
            var LookupCode = Entities.Lookups.FirstOrDefault(att => att.LookupId == lookupId).LookupCode;

            return LookupCode;
        }

        public void UpdateLookup(LookupDTO lookupDTO)
        {
            throw new NotImplementedException();
        }
    }
}
