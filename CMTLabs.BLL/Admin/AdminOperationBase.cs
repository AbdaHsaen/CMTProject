using CMTLabs.DAL.AdminManagers;
using CMTLabs.DAL.LookupCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMTLabs.BLL.Admin
{


    public class AdminOperationBase
    {
        private AdminManger _AdminManger;
        public AdminManger AdminManger
        {
            get
            {
                if (_AdminManger == null)
                    return new AdminManger();
                else
                    return this._AdminManger;
            }
            private set
            {
                _AdminManger = value;
            }
        }
        private LookupCategoryManager _LookupCategoryManager;
        public LookupCategoryManager LookupCategoryManager
        {
            get
            {
                if (_LookupCategoryManager == null)
                    return new LookupCategoryManager();
                else
                    return this._LookupCategoryManager;
            }

            private set
            {
                _LookupCategoryManager = value;
            }
        }

    }
}
