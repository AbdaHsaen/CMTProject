using CMTLabs.DAL.LookupsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.BLL.Helpers
{
    public static class Helper
    {
        public static string GetLookupCode(int lookupId)
        {
            LookupsManager _LookupsManager = new LookupsManager();

            return _LookupsManager.GetLookupCode(lookupId);
        }
    }
}
