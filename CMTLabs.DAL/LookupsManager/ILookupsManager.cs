using CMTLabs.Common.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.DAL.LookupsManager
{
    interface ILookupsManager
    {
        string GetLookupCode(int lookupId);

        void AddNewLookups(List<LookupDTO> LookupDTO);

        List<LookupDTO> GetAllLookupsByCategoryId(int CategoryId);

        void DeleteLookup(int LookupId);

        void UpdateLookup(LookupDTO lookupDTO);

        LookupDTO GetLookupById(int LookupId);

    }
}
